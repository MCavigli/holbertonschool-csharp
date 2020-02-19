using System;
using System.Collections.Generic;

namespace Text
{
	/// <summary>
	/// Class holds method to finds the index of the first non-repeating character of a stringj.
	/// </summary>
	public class Str
	{
		/// <summary>
		/// Returns index of first non-repeating character of a string.
		/// </summary>
		/// <param name="s">String to check.</param>
		/// <returns>Index of first non-repeating character.</returns>
		public static int UniqueChar(string s)
		{
			int i = 0;
			int j;
			List<char> repeat = new List<char>();
			List<int> noRepeat = new List<int>();
			for (; i <= s.Length - 1; i++)
			{

				for (j = i + 1; j <= s.Length - 1; j++)
				{

					if (repeat.Contains(s[i]))
						break;
					else if (s[i] == s[j])
					{
						repeat.Add(s[i]);
						break;
					}
					if (j == s.Length - 1 && !repeat.Contains(s[i]))
						noRepeat.Add(i);
				}
			}
			if (noRepeat.Count > 0)
				return (noRepeat[0]);
			return (-1);


		}
	}
}
