using System;

class VectorMath
{
	/// <summary>
	/// Finds the length of a 2D or 3D vector.
	/// </summary>
	/// <param name="vector">The vector to find the length of.</param>
	/// <returns>The length of the vector or -1 if the vector isn't 2D or 3D.</returns>
	public static double Magnitude(double[] vector)
	{
		int i;
		double result = 0.0;
		if (vector.Length < 2 || vector.Length > 3)
			return (-1);

		for (i = 0; i < vector.Length; i++)
			vector[i] = Math.Round(vector[i] * vector[i], 2);

		foreach (double dub in vector)
			result += result + dub;
		return (result);
	}
}
