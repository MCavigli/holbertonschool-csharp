using System;

class MatrixMath
{
	/// <summary>
	/// Adds two matrices together.
	/// </summary>
	/// <param name="matrix1">The first matrix.</param>
	/// <param name="matrix2">The second matrix.</param>
	/// <returns>A new matrix or -1 on fail.</returns>
	public static double[,] Add(double[,] matrix1, double[,] matrix2)
	{
		double[,] failMatrix = { { -1 } };
		if (matrix1.Length != matrix2.Length)
			return (failMatrix);
		if (matrix1.Length != 4 && matrix2.Length != 4 && matrix1.Length != 9 && matrix2.Length != 9)
			return (failMatrix);

		int i, j;

		if (matrix1.Length == 4)
			double[,] newMatrix = { { 0, 0 }, { 0, 0 } };
		else
			double[,] newMatrix = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

		for (i = 0; i < matrix1.GetLength(i); i++)
		{
			for (j = 0; j < matrix1.GetLength(j); j++)
				newMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
		}
		return (newMatrix);
	}
}
