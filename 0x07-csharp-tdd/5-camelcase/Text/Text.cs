using System;

namespace Text
{
	/// <summary>
	/// Class that holds method to count words.
	/// </summary>
	public class Str
	{
		/// <summary>
		/// Method returns how many words a string contains.
		/// </summary>
		/// <param name="s">String to check.</param>
		/// <returns>Number of words in the string.</returns>
		public static int CamelCase(string s)
		{
			int wordCount = 0;
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == ' ' && Char.IsUpper(s[i + 1]))
					wordCount += 1;
			}
			return (wordCount + 1);
		}
	}
}
