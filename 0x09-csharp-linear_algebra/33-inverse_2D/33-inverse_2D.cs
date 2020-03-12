using System;

class MatrixMath
{
	/// <summary>
	/// Finds the inverse of a 2D matrix.
	/// </summary>
	/// <param name="matrix">The 2D matrix.</param>
	/// <returns>A new 2D matrix that is the inverse of matrix.</returns>
	public static double[,] Inverse2D(double[,] matrix)
	{
		double[,] failMatrix = new double[,] { { -1 } };
		double d = 0;

		if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
			return (failMatrix);

		d = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
		if (d == 0)
			return (failMatrix);

		double[,] newMatrix = new double[,] {
			{(1 / d) * matrix[1, 1], (1 / d) * (matrix[0, 1] * -1)},
			{(1 / d) * (matrix[1, 0] * -1), (1 / d) * matrix[0, 0]}
		};
		return (newMatrix);
	}
}
