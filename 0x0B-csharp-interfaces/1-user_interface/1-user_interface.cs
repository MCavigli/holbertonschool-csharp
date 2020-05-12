using System;

/// <summary>
/// Base class
/// </summary>
public abstract class Base
{
	/// <summary>
	/// Name given
	/// </summary>
	public string name { get; set; }

	/// <summary>
	/// Overrides default ToString() method.
	/// </summary>
	public override string ToString()
	{
		return name + " is a " + this.GetType();
	}
}

interface IInteractive
{
	void Interact();
}

interface IBreakable
{
	int durability;
	void Break();
}

interface ICollectable
{
	bool isCollected;
	void Collect();
}

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
	// code
}