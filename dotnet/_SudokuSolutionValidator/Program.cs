public class Sudoku
{
	//--> https://www.codewars.com/kata/529bf0e9bdf7657179000008

	public static void Main()
	{
		//ValidateSolution(new int[][]
		//{
		//  new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
		//  new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
		//  new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
		//  new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
		//  new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
		//  new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
		//  new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
		//  new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
		//  new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
		//}
		//);

		ValidateSolution(new int[][]
		{
			new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
			new int[] {2, 3, 1, 5, 6, 4, 8, 9, 7},
			new int[] {3, 1, 2, 6, 4, 5, 9, 7, 8},
			new int[] {4, 5, 6, 7, 8, 9, 1, 2, 3},
			new int[] {5, 6, 4, 8, 9, 7, 2, 3, 1},
			new int[] {6, 4, 5, 9, 7, 8, 3, 1, 2},
			new int[] {7, 8, 9, 1, 2, 3, 4, 5, 6},
			new int[] {8, 9, 7, 2, 3, 1, 5, 6, 4},
			new int[] {9, 7, 8, 3, 1, 2, 6, 4, 5},
		}
		);

		//ValidateSolution(new int[][]
		//{
		//	new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9},
		//	new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9},
		//	new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9},
		//	new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9},
		//	new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9},
		//	new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9},
		//	new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9},
		//	new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9},
		//	new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9},
		//}
		//);
	}

	public static bool ValidateSolution(int[][] board)
	{
		bool validation = HorizontalValidation(board);
		validation = VerticalValidation(board);
		return validation;
	}

	public static bool HorizontalValidation(int[][] board)
	{
		for (int i = 0; i < board.Length; i++)
		{
			if (CountDuplicate(board[i]) > 0)
				return false;
		}

		return true;
	}

	public static bool VerticalValidation(int[][] board)
	{
		int[] newArray = new int[board.Length];

		for (int i = 0; i < board.Length; i++)
		{
			for (int j = 0; j < board[i].Length; j++)
			{
				var x = board[j][i];
				newArray[j] = x;
			}

			if (CountDuplicate(newArray) > 0)
				return false;

			Array.Clear(newArray, 0, newArray.Length);
		}

		return true;
	}

	public static int CountDuplicate(int[] intArray)
	{
		return intArray.GroupBy(x => x)
					.Where(x => x.Count() > 1)
					.Select(x => x.Key)
					.ToList()
					.Count();
	}

	public static bool QuadrantValidation()
	{

		return true;
	}
}