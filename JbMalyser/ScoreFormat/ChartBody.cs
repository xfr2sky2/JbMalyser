using System.Text;

namespace JbMalyser.ScoreFormat
{
	class ChartBody
	{
		private List<Measure> Measures { get; } = new();

		public ChartBody(IEnumerable<ChartElement> elements)
		{
			foreach (IGrouping<int, ChartElement> element in elements.GroupBy(e => e.Time.Beat / 4))
			{
				while (Measures.Count < element.Key)
				{
					Measures.Add(new(new List<ChartElement>(), 4, Measures.Count));
				}
				Measures.Add(new(element, 4, Measures.Count));
			}
		}

		public StringBuilder GenerateString()
		{
			StringBuilder retStr = new();
			int measureCount = 0;
			foreach (var measure in Measures)
			{
				measureCount++;
				retStr.Append(measureCount);
				retStr.AppendLine();
				retStr.Append(measure.GenerateString());
			}
			return retStr;
		}

	}
}
