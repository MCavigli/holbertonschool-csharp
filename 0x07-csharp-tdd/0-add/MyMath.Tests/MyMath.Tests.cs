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

		[Test]
		public void Add_IsInteger_NegativeInteger()
		{
			int a = -5;
			int b = 4;
			int result = Operations.Add(a, b);
			Assert.AreEqual(result, -1);
		}
		[Test]
		public void Add_IsInteger_NegativeIntegers()
		{
			int a = -5;
			int b = -4;
			int result = Operations.Add(a, b);
			Assert.AreEqual(result, -9);
		}
		[Test]
		public void Add_IsInteger_AddZero()
		{
			int a = 0;
			int b = 4;
			int result = Operations.Add(a, b);
			Assert.AreEqual(result, 4);
		}
		[Test]
		public void Add_IsInteger_AllZeroes()
		{
			int a = 0;
			int b = 0;
			int result = Operations.Add(a, b);
			Assert.AreEqual(result, 0);
		}
	}
}