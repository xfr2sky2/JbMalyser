
namespace JbMalyser.ScoreFormat
{
	class Tempo : ChartElementProperty
	{
		public float Bpm { get; }

		public Tempo(float bpm)
		{
			Bpm = bpm;
		}

		public override int CompareTo(ChartElementProperty other) =>
			other switch
			{
				ChipPosition => -1,
				_ => throw new InvalidOperationException(),
			};
	}
}
