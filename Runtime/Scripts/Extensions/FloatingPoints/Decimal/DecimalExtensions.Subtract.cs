namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		public static decimal Subtract(this decimal start, decimal increment)
		{
			return start - increment;
		}

		public static IEnumerable<decimal> Subtract(this decimal start, decimal increment, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException(nameof(count), count);
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return start -= increment;
			}
		}
	}
}