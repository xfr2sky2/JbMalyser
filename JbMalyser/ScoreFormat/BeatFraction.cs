
namespace JbMalyser.ScoreFormat
{
	struct BeatFraction : IComparable<BeatFraction>, IEquatable<BeatFraction>
	{
		private const int COMMON_BASE_DEN = 192;
		private readonly int _num;
		private readonly int _den;

		public BeatFraction(int num, int den)
		{
			_num = num;
			_den = den;
		}

		public int CompareTo(BeatFraction other)
		{
			int n = _num * other._den - other._num * _den;
			return n;
		}

		public static bool operator !=(BeatFraction r1, BeatFraction r2) => !(r1 == r2);
		public static bool operator ==(BeatFraction r1, BeatFraction r2) => r1.Equals(r2);

		public bool Equals(BeatFraction other) => CompareTo(other) == 0;

		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
			{
				return false;
			}
			return Equals((BeatFraction)obj);
		}

		public override int GetHashCode()
		{
			return COMMON_BASE_DEN * _num / _den;
		}

		public static int Flatten(IEnumerable<BeatFraction> fractions)
		{
			var commonDen = fractions.Select(t => new BeatFraction(COMMON_BASE_DEN * t._num / t._den, COMMON_BASE_DEN));
			int gcd = commonDen.Select(t => t._num).Append(COMMON_BASE_DEN).GeneralGcd();
			if (gcd == 0 || gcd == COMMON_BASE_DEN / 2 || gcd == COMMON_BASE_DEN) { gcd = COMMON_BASE_DEN / 4; }
			if (gcd == COMMON_BASE_DEN / 3) { gcd = COMMON_BASE_DEN / 6; }
			return COMMON_BASE_DEN / gcd;
		}
	}
}
