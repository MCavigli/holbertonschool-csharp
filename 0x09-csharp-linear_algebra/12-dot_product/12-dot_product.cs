using System;

class VectorMath
{
	/// <summary>
	/// Calculates dot product of a 2D or 3D vector.
	/// </summary>
	/// <param name="vector1">The first vector.</param>
	/// <param name="vector2">The second vector.</param>
	/// <returns>The dot product of the two vectors, or -1 on fail.</returns>
	public static double DotProduct(double[] vector1, double[] vector2)
	{
		if (vector1.Length < 2 || vector1.Length > 3 || vector2.Length < 2 || vector2.Length > 3)
			return (-1);
		if (vector1.Length != vector2.Length)
			return (-1);

		int i;
		double result = 0.0;
		// double[] resultVector = new double[vector1.Length];

		for (i = 0; i < vector1.Length; i++)
			result += vector1[i] * vector2[i];

		return (result);
	}
}
