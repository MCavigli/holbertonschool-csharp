using NUnit.Framework;
using MyMath;
using System;

namespace MyMath.Tests
{
	[TestFixture]
	public class Operations_Tests
	{
		[Test]
		public void Add_IsInteger_NumbersAreIntegers()
		{
			int a = 5;
			int b = 4;
			int result = Operations.Add(a, b);
			Assert.That(result, Is.EqualTo(9));
		}

		[Test]
		public void Add_IsInteger_ResultIsInteger()
		{
			int a = 5;
			int b = 4;
			int result = Operations.Add(a, b);
			Assert.That(result, Is.InstanceOf(typeof(int)));
		}
	}
}