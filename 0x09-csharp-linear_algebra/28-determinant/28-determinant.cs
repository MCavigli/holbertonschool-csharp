using System;

class MatrixMath
{
	/// <summary>
	/// Finds the determinant of a 2D or 3D matrix.
	/// </summary>
	/// <param name="matrix">The matrix.</param>
	/// <returns>The determinant of the matrix, -1 if not a 2D or 3D matrix.</returns>
	public static double Determinant(double[,] matrix)
	{
		double d = -1;

		if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
		{
			d = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
		}
		else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
		{
			d = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[2, 1] * matrix[1, 2]) -
				matrix[0, 1] * (matrix[0, 1] * matrix[2, 2] - matrix[2, 1] * matrix[0, 2]) +
				matrix[0, 2] * (matrix[0, 1] * matrix[1, 2] - matrix[1, 1] * matrix[0, 2]);
		}
		return (d);
	}
}
