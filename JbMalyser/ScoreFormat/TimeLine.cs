
namespace JbMalyser.ScoreFormat
{
	struct TimeLine : IComparable<TimeLine>, IEquatable<TimeLine>
	{
		public int Beat { get; }
		public BeatFraction Fraction { get; }
		public TimeLine(int beat, BeatFraction fraction)
		{
			Beat = beat;
			Fraction = fraction;
		}
		public TimeLine(int beat, int num, int den) : this(beat, new BeatFraction(num, den)) { }

		public int CompareTo(TimeLine other)
		{
			int b = Beat - other.Beat;
			if (b != 0) { return b; }
			int f = Fraction.CompareTo(other.Fraction);
			return f;
		}

		public static bool operator !=(TimeLine r1, TimeLine r2) => !(r1 == r2);
		public static bool operator ==(TimeLine r1, TimeLine r2) => r1.Equals(r2);

		public bool Equals(TimeLine other) => CompareTo(other) == 0;

		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
			{
				return false;
			}
			return Equals((TimeLine)obj);
		}

		public override int GetHashCode()
		{
			int b = new BeatFraction(1, 1).GetHashCode();
			return b * Beat + Fraction.GetHashCode();
		}
	}
}
