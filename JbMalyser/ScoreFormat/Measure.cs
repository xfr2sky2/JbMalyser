using System.Text;

namespace JbMalyser.ScoreFormat
{
	class Measure
	{
		private NotesTiming Timing { get; }

		private PanelArrengement Arrengement { get; }

		public Measure(IEnumerable<ChartElement> elements, int beats, int measureIndex)
		{
			Timing = new(elements, beats, measureIndex);
			Arrengement = new(elements, Timing.Beats);
		}

		public StringBuilder GenerateString()
		{
			List<StringBuilder> posStrs = Arrengement.GenerateString();
			List<StringBuilder> beatStrs = Timing.GenerateString();
			StringBuilder retStr = new();
			for (int lineCount = 0; lineCount < posStrs.Count; lineCount++)
			{
				retStr.Append(posStrs[lineCount]);
				if (lineCount < beatStrs.Count)
				{
					retStr.Append(beatStrs[lineCount]);
				}
				retStr.AppendLine();
			}
			return retStr;
		}
	}
}
