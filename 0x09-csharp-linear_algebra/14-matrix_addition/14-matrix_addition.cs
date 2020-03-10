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
		if (matrix1.GetLength(0) != 2 || matrix2.GetLength(0) != 3)
			return (failMatrix);

		int i, j;
		double[,] newMatrix;

		if (matrix1.Length == 4)
			newMatrix = new double[2, 2];
		else
			newMatrix = new double[3, 3];

		for (i = 0; i < matrix1.GetLength(i); i++)
		{
			for (j = 0; j < matrix1.GetLength(i); j++)
				newMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
		}
		return (newMatrix);
	}
}
