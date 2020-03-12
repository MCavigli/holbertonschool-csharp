using System;

class MatrixMath
{
	/// <summary>
	/// Rotates a 2x2 matrix by a given angle.
	/// </summary>
	/// <param name="matrix">The matrix to rotate.</param>
	/// <param name="angle">The angle to rotate the matrix by.</param>
	/// <returns>The new rotated, matrix, -1 on fail.</returns>
	public static double[,] Rotate2D(double[,] matrix, double angle)
	{
		double[,] failMatrix = { { -1 } };
		double[,] newMatrix;
		double[,] rotateMatrix = { { Math.Cos(angle), Math.Sin(angle) }, { Math.Cos(angle) * -1, Math.Sin(angle) } };
		int i, j, k;
		double prod = 0;

		if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
			newMatrix = new double[2, 2];
		else
			return (failMatrix);

		for (i = 0; i < 2; i++)
		{
			for (j = 0; j < 2; j++)
			{
				prod = 0;
				for (k = 0; k < 2; k++)
				{
					prod += Math.Round(matrix[i, k] * rotateMatrix[k, j]);
				}
				newMatrix[i, j] = prod;
			}
		}
		return (newMatrix);
	}
}
