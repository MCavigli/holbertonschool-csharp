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

		int i, j;
		double[,] newMatrix;

		if (matrix1.GetLength(0) == 2 && matrix2.GetLength(1) == 2 &&
			matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.GetLength(1) == matrix2.GetLength(1))
			newMatrix = new double[2, 2];
		else if (matrix1.GetLength(0) == 3 && matrix2.GetLength(1) == 3 &&
			matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.GetLength(1) == matrix2.GetLength(1))
			newMatrix = new double[3, 3];
		else
			return (failMatrix);

		for (i = 0; i < matrix1.GetLength(i); i++)
		{
			for (j = 0; j < matrix1.GetLength(i); j++)
				newMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
		}
		return (newMatrix);
	}
}