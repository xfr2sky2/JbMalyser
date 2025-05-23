using System.Text;

namespace JbMalyser.ScoreFormat
{
	class NotesTiming
	{
		private const char PART = '|';
		private const char BLANK = '－';
		private readonly char[] NUMS = "①②③④⑤⑥⑦⑧⑨⑩⑪⑫⑬⑭⑮⑯⑰⑱⑲⑳ＡＢＣＤＥＦＧＨＩＪＫＬ".ToCharArray();

		private Lookup<TimeLine, ChartElementProperty> Elements { get; }
		private List<BeatFraction>[] Fractions { get; }
		public List<TimeLine> Beats { get; }
		private int MeasureIndex { get; }

		public NotesTiming(IEnumerable<ChartElement> elements, int beats, int measureIndex)
		{
			// assert 1 <= beats && beats <= 4
			Elements = (Lookup<TimeLine, ChartElementProperty>)elements.ToLookup(e => e.Time, e => e.Property);
			Fractions = new List<BeatFraction>[beats];
			for (int i = 0; i < Fractions.Length; i++)
			{
				Fractions[i] = Elements.Select(g => g.Key).Where(t => t.Beat % 4 == i).Select(t => t.Fraction).ToList();
			}
			Beats = Elements.Where(g => g.Any(p => p is ChipPosition)).Select(g => g.Key).ToList();
			MeasureIndex = measureIndex;
		}

		public List<StringBuilder> GenerateString()
		{
			List<StringBuilder> sbList = new();
			int beatIndex = MeasureIndex * 4;
			int chipIndex = 0;
			foreach (List<BeatFraction> beatFractions in Fractions)
			{
				int beatDen = BeatFraction.Flatten(beatFractions);
				StringBuilder beatStr = new();
				beatStr.Append(PART);
				for (int beatNum = 0; beatNum < beatDen; beatNum++)
				{
					BeatFraction checkFraction = new(beatNum, beatDen);
					TimeLine checkTimeLine = new(beatIndex, checkFraction);
					if (beatFractions.Contains(checkFraction))
					{
						Tempo tempo = Elements[checkTimeLine].OfType<Tempo>().SingleOrDefault();
						if (tempo != null)
						{
							beatStr.Append($"({tempo.Bpm})");
						}
					}
					bool isBeat = Beats.Contains(checkTimeLine);
					beatStr.Append(isBeat ? NUMS[chipIndex++] : BLANK);
				}
				beatStr.Append(PART);
				sbList.Add(beatStr);
				beatIndex++;
			}
			return sbList;
		}
	}
}
