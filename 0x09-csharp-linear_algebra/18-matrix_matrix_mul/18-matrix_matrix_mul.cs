using System;

/// <summary>
/// Linear algebra with matrices.
/// </summary>
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
		double prod = 0;

		if (w1 == h2)
			newMatrix = new double[h1, w2];
		else
			return (failMatrix);

		for (i = 0; i < newMatrix.GetLength(0); i++)
		{
			for (j = 0; j < newMatrix.GetLength(1); j++)
			{
				prod = 0;
				for (k = 0; k < w1; k++)
				{
					prod += matrix1[i, k] * matrix2[k, j];
				}
				newMatrix[i, j] = prod;
			}
		}
		return (newMatrix);
	}
	// static void Main()
	// {
	// 	double[,] m1 = { { 2, 3 }, { -1, 2 } };
	// 	double[,] m2 = { { 1, 7 }, { -8, -2 } };
	// 	double[,] nm = Multiply(m1, m2);
	// 	int i, j;
	// 	for (i = 0; i < nm.GetLength(0); i++)
	// 	{
	// 		for (j = 0; j < nm.GetLength(1); j++)
	// 		{
	// 			Console.Write("{0} ", nm[i, j]);
	// 		}
	// 		Console.WriteLine();
	// 	}
	// }
}
