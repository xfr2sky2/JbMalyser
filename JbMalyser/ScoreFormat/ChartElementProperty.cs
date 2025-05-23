
namespace JbMalyser.ScoreFormat
{
	abstract class ChartElementProperty : IComparable<ChartElementProperty>
	{
		public abstract int CompareTo(ChartElementProperty other);
	}
}
