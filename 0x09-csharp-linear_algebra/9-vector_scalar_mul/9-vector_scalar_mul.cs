using System;

class VectorMath
{
	public static double[] Multiply(double[] vector, double scalar)
	{
		int i;
		double[] failVector = new double[] { -1 };

		if (vector.Length < 2 || vector.Length > 3)
			return (failVector);

		for (i = 0; i < vector.Length; i++)
			vector[i] = Math.Round(vector[i] * vector[i], 2);
		return (vector);
	}
}
