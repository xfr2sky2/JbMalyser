
namespace JbMalyser.ScoreFormat
{
	internal static class CalcUtil
	{
		public static int GeneralGcd(this IEnumerable<int> values)
		{
			IEnumerable<int> tmp = values.Select(Math.Abs).Where(v => v != 0);
			if (!tmp.Any()) { return 0; }
			while (tmp.Count() > 1)
			{
				int min = tmp.Min();
				tmp = tmp.Select(v => v % min).Append(min).Where(v => v != 0);
			}
			return tmp.First();
		}
	}
}
