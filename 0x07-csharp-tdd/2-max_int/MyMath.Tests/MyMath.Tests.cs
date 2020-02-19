using NUnit.Framework;
using MyMath;
using System.Collections.Generic;
using System;

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
		[Test]
		public void Max_MaxNum_MaxNumAtEnd()
		{
			List<int> endList = new List<int>() { 98, -10, 0, 32, 972, 12, 1024, -727, -98, 50, 8, 5000 };
			int result;
			result = Operations.Max(endList);
			Assert.AreEqual(5000, result);
		}
		[Test]
		public void Max_MaxNum_MaxNumAtBeginning()
		{
			List<int> begList = new List<int>() { 5000, 98, -10, 0, 32, 972, 12, 1024, -727, -98, 50, 8 };
			int result;
			result = Operations.Max(begList);
			Assert.AreEqual(5000, result);
		}
		[Test]
		public void Max_EmptyList()
		{
			List<int> eList = new List<int>() {};
			int result;
			try
			{
				result = Operations.Max(eList);
			}
			catch (NullReferenceException)
			{
				Assert.IsNull(eList);
			}
		}
	}
}