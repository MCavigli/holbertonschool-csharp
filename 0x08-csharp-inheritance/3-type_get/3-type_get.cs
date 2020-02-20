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
		IEnumerable<PropertyInfo> pList = t.DeclaredProperties;
		IEnumerable<MethodInfo> mList = t.DeclaredMethods;
		Console.WriteLine(t.Name + " Properties:");
		foreach (PropertyInfo p in pList)
			Console.WriteLine(p.Name);
		Console.WriteLine(t.Name + " Methods:");
		foreach (MethodInfo m in mList)
			Console.WriteLine(m.Name);
	}
}
