using NUnit.Framework;
using Text;

namespace Text.Tests
{
	[TestFixture]
	public class Str_Tests
	{
		[Test]
		public void Str_SuccessfulAttempt()
		{
			string s = "this Is A Test";
			Assert.AreEqual(4, Str.CamelCase(s));
		}
		[Test]
		public void Str_OneStr()
		{
			string s = "greetings";
			Assert.AreEqual(1, Str.CamelCase(s));
		}
	}
}