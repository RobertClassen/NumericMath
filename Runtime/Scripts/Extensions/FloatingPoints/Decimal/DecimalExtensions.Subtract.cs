namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		public static decimal Subtract(this decimal value, decimal subtrahend)
		{
			return value - subtrahend;
		}

		public static IEnumerable<decimal> Subtract(this decimal value, decimal subtrahend, int count)
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