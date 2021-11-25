namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		public static long Subtract(this long start, long increment)
		{
			return start - increment;
		}

		public static IEnumerable<long> Subtract(this long start, long increment, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException();
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return start -= increment;
			}
		}
	}
}