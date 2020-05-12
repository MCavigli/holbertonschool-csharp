using System;

class Base
{
	public string name { get; set; }

	public override string ToString()
	{
		return name + " is a " + typeof(SoftwareEngineer);
	}
}
