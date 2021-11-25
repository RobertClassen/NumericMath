namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		public static long Multiply(this long value, long factor)
		{
			return value * factor;
		}

		public static IEnumerable<long> Multiply(this long value, long factor, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException(nameof(count), count);
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return value *= factor;
			}
		}
	}
}