namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		public static int Sum(this IEnumerable<int> values)
		{
			int sum = Int.Zero;
			foreach(int value in values)
			{
				sum += value;
			}
			return sum;
		}
	}
}