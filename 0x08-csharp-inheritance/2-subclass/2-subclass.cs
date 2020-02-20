using System;

/// <summary>
/// Class that holds methods to understand subclass of an object.
/// </summary>
class Obj
{
	/// <summary>
	/// Method that displays if an object is a subclass of another object.
	/// </summary>
	/// <param name="derivedType">The derived object to check.</param>
	/// <param name="baseType">The base object to check derived object against.</param>
	/// <returns>True if derivedType is a subclass of baseType, false if not.</returns>
	public static bool IsOnlyASubclass(Type derivedType, Type baseType)
	{
		if (derivedType.IsSubclassOf(baseType))
			return true;
		else
			return false;
	}
}
