using System;

class MatrixMath
{
	/// <summary>
	/// Multiplies two matrices together.
	/// </summary>
	/// <param name="matrix1">The first matrix.</param>
	/// <param name="matrix2">The second matrix.</param>
	/// <returns>A new matrix, -1 on fail.</returns>
	public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
	{
		int h1 = matrix1.GetLength(0);
		int w1 = matrix1.GetLength(1);
		int h2 = matrix2.GetLength(0);
		int w2 = matrix2.GetLength(1);
		double[,] failMatrix = { { -1 } };
		double[,] newMatrix;
		int i, j, k;
		// int result = 0;
		int prod = 0;

		if (w1 == h2)
			newMatrix = new double[h1, w2];
		else
			return (failMatrix);

		for (i = 0; i < h1; i++)
		{
			for (j = 0; j < h1; j++)
			{
				for (k = 0; k < w2; k++)
				{
					prod += matrix1[i, j] * matrix2[j, k];
				}
				newMatrix[i, j] = prod;
			}
		}
		return (newMatrix);
	}
}
