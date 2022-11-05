namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		public static long Sum(this IEnumerable<long> values)
		{
			long sum = Long.Zero;
			foreach(long value in values)
			{
				sum += value;
			}
			return sum;
		}
	}
}