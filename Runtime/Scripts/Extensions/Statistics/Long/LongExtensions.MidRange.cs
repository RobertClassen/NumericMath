namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		public static double MidRange(this IEnumerable<long> values)
		{
			long min = long.MaxValue;
			long max = long.MinValue;
			foreach(long value in values)
			{
				if(value < min)
				{
					min = value;
				}
				if(value > max)
				{
					max = value;
				}
			}
			return (min + max) * Double.OneHalf;
		}
	}
}