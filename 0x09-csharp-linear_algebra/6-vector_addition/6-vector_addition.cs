using System;

class VectorMath
{
	/// <summary>
	/// Function that finds the length of a 2D or 3D vector.
	/// </summary>
	/// <param name="vector1">The first vector.</param>
	/// <param name="vector2">The second vector.</param>
	/// <returns>The length of the vector or -1 if either vector is not a 2D or 3D vector.</returns>
	public static double[] Add(double[] vector1, double[] vector2)
	{
		int i;
		double[] failVector = new double[] { -1 };

		if (vector1.Length != vector2.Length)
			return (failVector);
		if (vector1.Length < 2 || vector1.Length > 3 || vector2.Length < 2 || vector2.Length > 3)
			return (failVector);

		double[] vector3 = new double[vector1.Length];

		for (i = 0; i < vector1.Length; i++)
			vector3[i] = vector1[i] + vector2[i];

		return (vector3);
	}
}
