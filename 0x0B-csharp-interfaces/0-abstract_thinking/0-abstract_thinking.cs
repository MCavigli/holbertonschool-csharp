using System;

/// <summary>
/// Base class
/// </summary>
abstract class Base
{
	public string name { get; set; }

	/// <summary>
	/// Overrides default ToString() method.
	/// </summary>
	public override string ToString()
	{
		return name + " is a " + typeof(SoftwareEngineer);
	}
}
