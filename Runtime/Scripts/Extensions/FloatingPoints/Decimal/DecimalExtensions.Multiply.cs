namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		public static decimal Multiply(this decimal value, decimal factor)
		{
			return value * factor;
		}

		public static IEnumerable<decimal> Multiply(this decimal value, decimal factor, int count)
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