using System;

class MatrixMath
{
	/// <summary>
	/// Multiplies a matrix by a scalar.
	/// </summary>
	/// <param name="matrix">The matrix.</param>
	/// <param name="scalar">The scalar.</param>
	/// <returns>A new matrix.</returns>
	public static double[,] MultiplyScalar(double[,] matrix, double scalar)
	{
		double[,] newMatrix;
		double[,] failMatrix = { { -1 } };
		int h = matrix.GetLength(0);
		int w = matrix.GetLength(1);
		int i, j;

		if (h == 2 && w == 2)
			newMatrix = new double[2, 2];
		else if (h == 3 && w == 3)
			newMatrix = new double[3, 3];
		else
			return (failMatrix);
		for (i = 0; i < h; i++)
		{
			for (j = 0; j < w; j++)
			{
				newMatrix[i, j] = matrix[i, j] * scalar;
			}
		}
		return (newMatrix);
	}
}
