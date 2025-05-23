
namespace JbMalyser.ScoreFormat
{
	class ChartElement : IComparable<ChartElement>
	{
		public TimeLine Time { get; }
		public ChartElementProperty Property { get; }
		public ChartElement(TimeLine time, ChartElementProperty property)
		{
			Time = time;
			Property = property;
		}
		public int CompareTo(ChartElement other)
		{
			int b = Time.CompareTo(other.Time);
			if (b != 0) { return b; }
			int f = Property.CompareTo(other.Property);
			return f;
		}
	}
}
