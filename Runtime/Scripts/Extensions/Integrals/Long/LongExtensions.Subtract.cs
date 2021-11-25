namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		public static long Subtract(this long value, long subtrahend)
		{
			return value - subtrahend;
		}

		public static IEnumerable<long> Subtract(this long value, long subtrahend, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException(nameof(count), count);
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return value -= subtrahend;
			}
		}
	}
}