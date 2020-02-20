using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// Class that holds methods to work on an object.
/// </summary>
class Obj
{
	/// <summary>
	/// Method that prints out the properties and methods of an object.
	/// </summary>
	/// <param name="myObj">The object.</param>
	public static void Print(object myObj)
	{
		TypeInfo t = myObj.GetType().GetTypeInfo();
		Console.WriteLine(t.Name + " Properties:");
		foreach (PropertyInfo p in t.GetProperties())
			Console.WriteLine(p.Name);
		Console.WriteLine(t.Name + " Methods:");
		foreach (MethodInfo m in t.GetMethods())
			Console.WriteLine(m.Name);
	}
}
