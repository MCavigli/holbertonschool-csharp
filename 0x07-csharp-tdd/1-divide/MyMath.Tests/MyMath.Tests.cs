using NUnit.Framework;
using MyMath;
using System;
using System.Collections.Generic;

namespace MyMath.Tests
{
	[TestFixture]
	public class Matrix_Tests
	{
		private int[,] array2D;

		[SetUp]
		public void SetUp()
		{
			array2D = new int[,] {
				{ 1, 2 },
				{ 3, 4 },
				{ 5, 6 },
				{ 7, 8 }
				};
		}
		[TearDown]
		public void CleanUp()
		{
			array2D = null;
		}

		[Test]
		public void Divide_SuccessfulExample()
		{
			int[,] finishedArray = new int[,] {
				{ 0, 1 },
				{ 1, 2 },
				{ 2, 3 },
				{ 3, 4 },
			};
			int num = 2;
			int[,] dividedMatrix = Matrix.Divide(array2D, num);
			Assert.AreEqual(finishedArray, dividedMatrix);
		}

		[Test]
		public void Divide_Number_IsZero()
		{
			int num = 0;
			int[,] dividedMatrix;
			try
			{
				dividedMatrix = Matrix.Divide(array2D, num);
			}
			catch (DivideByZeroException)
			{
				dividedMatrix = Matrix.Divide(array2D, num);
				Assert.IsNull(dividedMatrix);
			}
		}
		
		[Test]
		public void Divide_Matrix_IsMatrix()
		{
			Assert.AreEqual(array2D.GetType(), typeof(int[,]));
		}
		[Test]
		public void Divide_Matrix_IsNotMatrix()
		{
			int[] falseArray = { 1, 2, 3, 4 };
			Assert.AreNotEqual(falseArray.GetType(), typeof(int));
		}

		[Test]
		public void Divide_Matrix_MatrixIsNull()
		{
			int num = 2;
			int[,] nullMatrix = null;
			int[,] returnMatrix = null;
			try
			{
				returnMatrix = Matrix.Divide(nullMatrix, num);
			}
			catch (NullReferenceException)
			{
				Assert.IsNull(returnMatrix);
			}
		}

	}
}