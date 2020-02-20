using NUnit.Framework;

namespace Text.Tests
{
	[TestFixture]
	public class Str_Tests
	{
		// [SetUp]
		// public void Setup()
		// {
		// }

		[Test]
		public void Str_SuccessfulExample()
		{
			string strRight = "racecar";
			Assert.IsTrue(Str.IsPalindrome(strRight));
		}
		[Test]
		public void Str_s_UnsuccessfulExample()
		{
			string strWrong = "notapalindrome";
			Assert.IsFalse(Str.IsPalindrome(strWrong));
		}
		[Test]
		public void Str_SuccessfulExample_WithSpaces()
		{
			string strRight = "race car";
			Assert.IsTrue(Str.IsPalindrome(strRight));
		}
		[Test]
		public void Str_s_UnsuccessfulExample_WithSpaces()
		{
			string strWrong = "not a palindrome";
			Assert.IsFalse(Str.IsPalindrome(strWrong));
		}
		[Test]
		public void Str_s_ContainsOtherCharacters()
		{
			string strChar = "desserts, i stressed!";
			Assert.IsTrue(Str.IsPalindrome(strChar));
		}
		[Test]
		public void Str_s_ContainsUpperCase()
		{
			string strCase = "DessertsIstressed";
			Assert.IsTrue(Str.IsPalindrome(strCase));
		}
		[Test]
		public void Str_s_ContainsOtherCharAndUpperCase()
		{
			string strCharCase = "Desserts, I stressed!";
			Assert.IsTrue(Str.IsPalindrome(strCharCase));
		}
		[Test]
		public void Str_s_IsEmpty()
		{
			string str = "";
			Assert.IsTrue(Str.IsPalindrome(str));
		}

	}
}