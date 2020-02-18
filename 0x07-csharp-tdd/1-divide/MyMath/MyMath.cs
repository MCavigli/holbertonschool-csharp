using System;

namespace MyMath
{
	/// <summary>
	/// Holds methods to alter a matrix.
	/// </summary>
	public class Matrix
	{
		/// <summary>
		/// Divides each element of a matrix.
		/// </summary>
		/// <param name="matrix">The matrix to be divided.</param>
		/// <param name="num">The number to divide all matrix elements by.</param>
		/// <returns></returns>
		public static int[,] Divide(int[,] matrix, int num)
		{
			int[,] newMatrix = matrix.Clone() as int[,];
			if (num == 0)
			{
				Console.WriteLine("Num cannot be 0");
				return (null);
			}
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					newMatrix[i, j] /= num;
				}
			}
			return (newMatrix);
		}
	}
}
