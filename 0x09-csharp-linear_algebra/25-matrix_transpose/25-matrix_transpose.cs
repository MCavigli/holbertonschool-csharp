using System;

class MatrixMath
{
	/// <summary>
	/// Transposes a matrix.
	/// </summary>
	/// <param name="matrix">The matrix.</param>
	/// <returns>The new, transposed matrix.</returns>
	public static double[,] Transpose(double[,] matrix)
	{
		double[,] failMatrix = { { -1 } };
		double[,] newMatrix;

		if (matrix.Length == 0)
			return failMatrix;

		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				newMatrix[i, j] = matrix[j, i];
			}
		}
		return (newMatrix);
	}
}
