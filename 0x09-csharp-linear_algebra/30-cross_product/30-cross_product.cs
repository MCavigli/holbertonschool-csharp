using System;

class VectorMath
{
	/// <summary>
	/// Calculates cross product between two 3D vectors;
	/// </summary>
	/// <returns>The cross product, -1 on fail.</returns>
	public static double[] CrossProduct(double[] vector1, double[] vector2)
	{
		double[] failVector = { -1 };
		double[] newVector = new double[3];

		if (vector1.Length != 3 || vector2.Length != 3)
			return (failVector);

		newVector[0] = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
		newVector[1] = (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]);
		newVector[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);

		return (newVector);
	}
}
