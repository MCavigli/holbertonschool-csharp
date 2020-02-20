using System;

/// <summary>
/// Class holding method to check if an object is an integer.
/// </summary>
class Obj
{
	/// <summary>
	/// Returns true if object is an integer, false if not.
	/// </summary>
	/// <param name="obj">The object to check.</param>
	/// <returns>True if object is an integer, false if not.</returns>
	public static bool IsOfTypeInt(object obj)
	{
		if (obj is int)
			return (true);
		else
			return (false);
	}
}
