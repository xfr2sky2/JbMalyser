
namespace JbMalyser.ScoreFormat
{
	class ChipHoldPosition : ChipPosition
	{
		private record ArrowBarDirection(char ArrowChar, char BarChar)
		{
			private const char ARROW_CHAR_LEFT_TO_RIGHT = '＞';
			private const char ARROW_CHAR_RIGHT_TO_LEFT = '＜';
			private const char ARROW_CHAR_UP_TO_DOWN = '∨';
			private const char ARROW_CHAR_DOWN_TO_UP = '∧';
			private const char BAR_CHAR_HORIZONTAL = '―';
			private const char BAR_CHAR_VERTICAL = '｜';

			public static ArrowBarDirection LeftToRight { get; } = new ArrowBarDirection(ARROW_CHAR_LEFT_TO_RIGHT, BAR_CHAR_HORIZONTAL);
			public static ArrowBarDirection RightToLeft { get; } = new ArrowBarDirection(ARROW_CHAR_RIGHT_TO_LEFT, BAR_CHAR_HORIZONTAL);
			public static ArrowBarDirection UpToDown { get; } = new ArrowBarDirection(ARROW_CHAR_UP_TO_DOWN, BAR_CHAR_VERTICAL);
			public static ArrowBarDirection DownToUp { get; } = new ArrowBarDirection(ARROW_CHAR_DOWN_TO_UP, BAR_CHAR_VERTICAL);
		}

		public int ArrowPosition { get; }
		public int[] BarPositions { get; }
		private ArrowBarDirection Direction { get; }
		public char ArrowChar { get => Direction.ArrowChar; }
		public char BarChar { get => Direction.BarChar; }

		public ChipHoldPosition(int position, int arrowPosition) : base(position)
		{
			ArrowPosition = arrowPosition;
			CalcLengthAndDirection(out ArrowBarDirection direction, out int[] barPositions);
			BarPositions = barPositions;
			Direction = direction;
		}

		private void CalcLengthAndDirection(out ArrowBarDirection direction, out int[] barPositions)
		{
			const int COL_MAX = 4;
			int touchRow = Position / COL_MAX;
			int touchCol = Position % COL_MAX;
			int arrowRow = ArrowPosition / COL_MAX;
			int arrowCol = ArrowPosition % COL_MAX;

			int length;
			int refPosition;
			int incPosition;
			int rowDiff = touchRow - arrowRow;
			int colDiff = touchCol - arrowCol;
			switch ((rowDiff, colDiff))
			{
				case (0, > 0): // left to right [＞]
					direction = ArrowBarDirection.LeftToRight;
					length = colDiff;
					refPosition = ArrowPosition;
					incPosition = 1;
					break;
				case (0, < 0): // right to left [＜]
					direction = ArrowBarDirection.RightToLeft;
					length = -colDiff;
					refPosition = Position;
					incPosition = 1;
					break;
				case (> 0, 0): // up to down [∨]
					direction = ArrowBarDirection.UpToDown;
					length = rowDiff;
					refPosition = ArrowPosition;
					incPosition = COL_MAX;
					break;
				case (< 0, 0): // down to up [∧]
					direction = ArrowBarDirection.DownToUp;
					length = -rowDiff;
					refPosition = Position;
					incPosition = COL_MAX;
					break;
				default:
					throw new InvalidOperationException();
			}
			barPositions = new int[length - 1];
			for (int i = 1; i < length; i++)
			{
				barPositions[i - 1] = refPosition + incPosition * i;
			}
		}
	}
}
