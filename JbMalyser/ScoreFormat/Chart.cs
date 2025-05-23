using System.Text;
using Newtonsoft.Json;

namespace JbMalyser.ScoreFormat
{
	class Chart
	{
		public int OffsetTime { get; set; } = 0;
		public string SoundPath { get; set; } = "";
		public float Level { get; set; } = 0;
		public bool NeedLevelDecimalPoint { get; set; } = true;
		public int Difficulty { get; set; } = 0;
		public string Title { get; set; } = "";
		public string Artist { get; set; } = "";
		public string JacketPath { get; set; } = "";
		public int PreviewPositionTime { get; set; } = 0;
		public int OffsetBeat
		{
			get => offsetBeat;
			set
			{
				OffsetTime += (int)((value - offsetBeat) * 60000 / _bpm);
				offsetBeat = value;
			}
		}
		private int offsetBeat;
		public int GeneralOffset { get; set; } = 0;

		private ChartBody ChartBody
			=> new(_chartElements.Select(
				e => new ChartElement(
					new TimeLine(e.Time.Beat - OffsetBeat, e.Time.Fraction)
					, e.Property
				)
			));

		private readonly SortedSet<ChartElement> _chartElements = [];
		private readonly float _bpm = 120;
		public readonly int _offset = 0;
		private readonly bool _isHold = false;

		public static Chart FromPath(string path)
		{
			McJson.Root mcjson;
			using (JsonReader reader = new JsonTextReader(File.OpenText(path)))
			{
				JsonSerializer serializer = new();
				mcjson = serializer.Deserialize<McJson.Root>(reader);
			}
			return new Chart(mcjson);
		}

		private Chart(McJson.Root mcjson)
		{
			float rootBpm = 0;
			foreach (var time in mcjson.time)
			{
				var beat = time.beat;
				var bpm = time.bpm.Value;
				if (rootBpm == 0)
				{
					rootBpm = bpm;
					continue;
				}
				TimeLine timeLine = new(beat[0], beat[1], beat[2]);
				Tempo tempo = new(bpm);
				_chartElements.Add(new ChartElement(timeLine, tempo));
			}
			string sound = "";
			foreach (var note in mcjson.note)
			{
				var beat = note.beat;
				var index = note.index;
				if (index == null)
				{
					sound = note.sound;
					_offset = note.offset ?? 0;
					continue;
				}
				TimeLine timeLine = new(beat[0], beat[1], beat[2]);
				var endbeat = note.endbeat;
				var endindex = note.endindex;
				if (endbeat != null && endindex != null)
				{
					_isHold = true;
					ChipHoldPosition chipHold = new(index.Value, endindex.Value);
					_chartElements.Add(new ChartElement(timeLine, chipHold));
					TimeLine timeLineEnd = new(endbeat[0], endbeat[1], endbeat[2]);
					ChipPosition chipEnd = new(index.Value);
					_chartElements.Add(new ChartElement(timeLineEnd, chipEnd));
				}
				else
				{
					ChipPosition chip = new(index.Value);
					_chartElements.Add(new ChartElement(timeLine, chip));
				}
			}
			float level = 0;
			int difficulty = 0;
			if (mcjson.meta.version != null)
			{
				string[] v = mcjson.meta.version.Split('-');
				if (v.Length >= 2)
				{
					string diffStr = v[0].ToLower();
					difficulty = diffStr switch
					{
						"bsc" or "basic" => 1,
						"adv" or "advanced" => 2,
						"ext" or "extreme" => 3,
						"edt" or "edit" => 4,
						_ => 0,
					};
					_ = float.TryParse(v[1], out level);
				}
			}
			_bpm = rootBpm;
			OffsetTime = -_offset + GeneralOffset;
			SoundPath = sound;
			Level = level;
			Difficulty = difficulty;
			Title = mcjson.meta.song.title;
			Artist = mcjson.meta.song.artist;
			JacketPath = mcjson.meta.background;
			PreviewPositionTime = ((mcjson.meta.preview - _offset) ?? 0) + GeneralOffset;
		}

		public void WriteTo(string outPath)
		{
			WriteTo(File.Create(outPath));
		}

		public void WriteTo(Stream stream)
		{
			EncodingProvider provider = CodePagesEncodingProvider.Instance;
			Encoding encoding = provider.GetEncoding("shift-jis");
			using var writer = new StreamWriter(stream, encoding);
			WriteMemoTextTo(writer);
		}

		public string GetStringAsMemoFormat()
		{
			using var mstream = new MemoryStream();
			using var writer = new StreamWriter(mstream);
			WriteMemoTextTo(writer);
			return Encoding.UTF8.GetString(mstream.ToArray());
		}

		private void WriteMemoTextTo(StreamWriter writer)
		{
			writer.WriteLine("//Auto converted by JbMalyser.");
			writer.WriteLine($"t={_bpm}");
			writer.WriteLine($"o={OffsetTime}");
			writer.WriteLine($"m=\"{SoundPath}\"");
			string levelFormat = NeedLevelDecimalPoint ? "F1" : "F0";
			writer.WriteLine($"#lev={Level.ToString(levelFormat)}");
			writer.WriteLine($"#dif={Difficulty}");
			writer.WriteLine($"#title=\"{Title}\"");
			writer.WriteLine($"#artist=\"{Artist}\"");
			writer.WriteLine($"#jacket=\"{JacketPath}\"");
			writer.WriteLine($"#prevpos={PreviewPositionTime}");
			writer.WriteLine("#memo2");
			if (_isHold) { writer.WriteLine("#holdbyarrow=1"); }
			writer.WriteLine();
			writer.Write(ChartBody.GenerateString().ToString());
		}
	}
}
