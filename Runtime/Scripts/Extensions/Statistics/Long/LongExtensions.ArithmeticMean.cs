namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		public static long ArithmeticMean(this IEnumerable<long> values)
		{
			double sum = Double.Zero;
			int count = Int.Zero;
			foreach(long value in values)
			{
				sum += value;
				count++;
			}
			return (long)(sum / (double)count);
		}
	}
}