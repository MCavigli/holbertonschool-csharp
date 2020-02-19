using NUnit.Framework;
using Text;

namespace Text.Tests
{
	[TestFixture]
	public class Str_Tests
	{
		private string s;
		private string s2;
		private string s3;
		[SetUp]
		public void SetUp()
		{
			s = "heywhatsuphowsitgoing";
			s2 = "norepats";
			s3 = "allrepeatsrpts";
		}
		[Test]
		public void Str_NoRepeats()
		{
			int result = Str.UniqueChar(s2);
			Assert.AreEqual(0, result);
		}
		[Test]
		public void Str_Repeats()
		{
			int result = Str.UniqueChar(s);
			Assert.AreEqual(1, result);
		}
		[Test]
		public void Str_AllRepeats()
		{
			int result = Str.UniqueChar(s3);
			Assert.AreEqual(-1, result);
		}
	}
}