using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
	[TestFixture]
	public class Operations_Tests
	{
		private List<int> myList1;

		[SetUp]
		public void Setup()
		{
			myList1 = new List<int>() { 98, -10, 0, 32, 972, 12, 1024, -727, -98, 50, 8 };
		}

		[Test]
		public void Max_SuccessfulExample()
		{
			int result = Operations.Max(myList1);
			Assert.AreEqual(1024, result);
		}

		[Test]
		public void Max_Nums_IsZero()
		{
			List<int> myListEmpty = new List<int>();
			int result;
			result = Operations.Max(myListEmpty);
			Assert.AreEqual(0, result);
		}
	}
}