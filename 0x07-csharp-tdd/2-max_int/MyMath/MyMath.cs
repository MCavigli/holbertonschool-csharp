using System;
using System.Collections.Generic;


namespace MyMath
{
	/// <summary>
	/// Holds method to return max number in a list.
	/// </summary>
	public class Operations
	{
		/// <summary>
		/// Method returns the largest integer in a list.
		/// </summary>
		/// <param name="nums">List of integers.</param>
		/// <returns></returns>
		public static int Max(List<int> nums)
		{
			if (nums.Count == 0)
				return (0);
			nums.Sort();
			return (nums[nums.Count - 1]);
		}
	}
}
