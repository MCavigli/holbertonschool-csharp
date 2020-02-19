using System;
using System.Collections.Generic;

namespace Text
{
	/// <summary>
	/// Class that runs different methods on strings.
	/// </summary>
	public class Str
	{
		/// <summary>
		/// Checks if string is a palindrome.
		/// </summary>
		/// <param name="s">String to check.</param>
		/// <returns></returns>
		public static bool IsPalindrome(string s)
		{
			if (string.IsNullOrEmpty(s))
				return (true);
			string newS = s.ToLower();
			string reverse;
			char[] charArray;
			string first;
			string second;
			List<char> removeChar = new List<char>();
			for (int i = 0; i < newS.Length; i++)
			{
				if (newS[i] >= 'a' && newS[i] <= 'z')
					removeChar.Add(newS[i]);
			}
			newS = string.Join("", removeChar);
			charArray = newS.ToCharArray();
			Array.Reverse(charArray);
			reverse = new string(charArray);
			Console.WriteLine("newS: {0}", newS);
			Console.WriteLine("reverse: {0}", reverse);
			first = newS.Substring(0, newS.Length / 2);
			second = reverse.Substring(0, reverse.Length / 2);
			Console.WriteLine("first: {0}", first);
			Console.WriteLine("second: {0}", second);
			return (newS.Equals(reverse));

		}
		// public static string IsPalindrome(string s)
		// {
		// 	string newS = s.ToLower();
		// 	string reverse;
		// 	char[] charArray;
		// 	List<char> removeChar = new List<char>();
		// 	for (int i = 0; i < newS.Length; i++)
		// 	{
		// 		if (newS[i] >= 'a' && newS[i] <= 'z')
		// 			removeChar.Add(newS[i]);
		// 	}
		// 	newS = string.Join("", removeChar);
		// 	charArray = newS.ToCharArray();
		// 	Array.Reverse(charArray);
		// 	reverse = new string(charArray);

		// 	return (newS.Equals(reverse));
		// }
	}
}
