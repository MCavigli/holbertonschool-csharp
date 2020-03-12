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
			{Math.Round((1 / d) * matrix[1, 1], 2), Math.Round((1 / d) * -matrix[0, 1], 2)},
			{Math.Round((1 / d) * -matrix[1, 0], 2), Math.Round((1 / d) * matrix[0, 0], 2)}
		};
		return (newMatrix);
	}
	// public static void Main()
	// {
	// 	double[,] m = new double[,] { { 1, 2 }, { 3, 4 } };
	// 	double[,] nm = Inverse2D(m);
	// 	for (int i = 0; i < nm.GetLength(0); i++)
	// 	{
	// 		for (int j = 0; j < nm.GetLength(1); j++)
	// 		{
	// 			Console.Write("{0} ", nm[i, j]);
	// 		}
	// 		Console.WriteLine();
	// 	}
	// }
}
