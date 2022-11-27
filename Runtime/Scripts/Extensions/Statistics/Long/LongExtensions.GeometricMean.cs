namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		public static long GeometricMean(this IEnumerable<long> values)
		{
			double sum = Double.One;
			int count = Int.Zero;
			foreach(long value in values)
			{
				sum *= value;
				count++;
			}
			return (long)sum.Root(count);
		}
	}
}