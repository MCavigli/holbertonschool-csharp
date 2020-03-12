using System;

class MatrixMath
{
	/// <summary>
	/// Shears a square 2D matrix by a given factor.
	/// </summary>
	/// <param name="matrix">The matrix.</param>
	/// <param name="direction">The direction to shear.</param>
	/// <param name="factor">How much to shear by.</param>
	/// <returns>A new sheared matrix, -1 on fail.</returns>
	public static double[,] Shear2D(double[,] matrix, char direction, double factor)
	{
		double[,] failMatrix = { { -1 } };
		double[,] newMatrix = new double[2, 2];
		double[,] shear;
		int i, j, k;
		double prod = 0;

		if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
			return (failMatrix);

		if (direction == 'x')
			shear = new double[,] { { 1, 0 }, { factor, 1 } };
		else if (direction == 'y')
			shear = new double[,] { { 1, factor }, { 0, 1 } };
		else
			return (failMatrix);

		for (i = 0; i < 2; i++)
		{
			for (j = 0; j < 2; j++)
			{
				prod = 0;
				for (k = 0; k < 2; k++)
				{
					prod += matrix[i, k] * shear[k, j];
				}
				newMatrix[i, j] = Math.Round(prod, 2);
			}
		}
		return (newMatrix);
	}
}
