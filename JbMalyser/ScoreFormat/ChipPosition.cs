
namespace JbMalyser.ScoreFormat
{
	class ChipPosition : ChartElementProperty, IComparable<ChipPosition>
	{
		public int Position { get; }
		public ChipPosition(int position)
		{
			Position = position;
		}
		public int CompareTo(ChipPosition other) => Position - other.Position;
		public override int CompareTo(ChartElementProperty other) =>
			other switch
			{
				ChipPosition c => CompareTo(c),
				Tempo => 1,
				_ => throw new InvalidOperationException(),
			};
	}
}
