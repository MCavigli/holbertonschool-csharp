using System;

class MatrixMath
{
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

		for (i = 0; i < newMatrix.GetLength(0); i++)
		{
			for (j = 0; j < newMatrix.GetLength(1); j++)
			{
				prod = 0;
				for (k = 0; k < w1; k++)
				{
					prod += matrix[i, k] * rotateMatrix[k, j];
				}
				newMatrix[i, j] = prod;
			}
		}
		return (newMatrix);
	}
}
