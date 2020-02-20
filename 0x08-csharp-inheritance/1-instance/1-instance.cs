using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Class holding methods to work on an object of unknown type.
/// </summary>
class Obj
{
	/// <summary>
	/// Method that checks if an object is an instance of an Array or an instance of a class that inherits from an Array.
	/// </summary>
	/// <param name="obj">The object to check.</param>
	/// <returns>True if object is an instance of an Array, false if not.</returns>
	public static bool IsInstanceOfArray(object obj)
	{
		if (obj is Array)
			return true;
		else
			return false;
	}
}
