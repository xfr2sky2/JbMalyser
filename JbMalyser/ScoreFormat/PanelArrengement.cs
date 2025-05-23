using System.Text;

namespace JbMalyser.ScoreFormat
{
	class PanelArrengement
	{
		private const char BLANK = '□';
		private readonly char[] NUMS = "①②③④⑤⑥⑦⑧⑨⑩⑪⑫⑬⑭⑮⑯⑰⑱⑲⑳ＡＢＣＤＥＦＧＨＩＪＫＬ".ToCharArray();

		private List<char[]> PanelCharsList { get; }

		private static char[] NewPanelChars()
		{
			char[] ret = new char[16];
			Array.Fill(ret, BLANK);
			return ret;
		}

		public PanelArrengement(IEnumerable<ChartElement> elements, List<TimeLine> times)
		{
			PanelCharsList = new() { NewPanelChars() };
			foreach (ChartElement element in elements)
			{
				if (element.Property is ChipHoldPosition hold)
				{
					if (PanelCharsList[^1][hold.Position] != BLANK || PanelCharsList[^1][hold.ArrowPosition] != BLANK)
					{
						PanelCharsList.Add(NewPanelChars());
					}
					else
					{
						foreach (int position in hold.BarPositions)
						{
							if (PanelCharsList[^1][position] != BLANK)
							{
								PanelCharsList.Add(NewPanelChars());
								break;
							}
						}
					}
					PanelCharsList[^1][hold.Position] = NUMS[times.FindIndex(t => t == element.Time)];
					PanelCharsList[^1][hold.ArrowPosition] = hold.ArrowChar;
					foreach (int position in hold.BarPositions)
					{
						PanelCharsList[^1][position] = hold.BarChar;
					}
				}
				else if (element.Property is ChipPosition chip)
				{
					if (PanelCharsList[^1][chip.Position] != BLANK)
					{
						PanelCharsList.Add(NewPanelChars());
					}
					PanelCharsList[^1][chip.Position] = NUMS[times.FindIndex(t => t == element.Time)];
				}
			}
		}

		public List<StringBuilder> GenerateString()
		{
			List<StringBuilder> sbList = new();
			foreach (char[] panelChars in PanelCharsList)
			{
				if (sbList.Count != 0) { sbList.Add(new()); }
				StringBuilder sb = new();
				int index = 0;
				foreach (char panelChar in panelChars)
				{
					sb.Append(panelChar);
					if (++index % 4 == 0)
					{
						sbList.Add(sb);
						sb = new();
					}
				}
			}
			return sbList;
		}
	}
}
