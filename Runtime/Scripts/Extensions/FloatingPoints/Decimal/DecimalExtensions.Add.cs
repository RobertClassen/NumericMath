namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		public static decimal Add(this decimal value, decimal addend)
		{
			return value + addend;
		}

		public static IEnumerable<decimal> Add(this decimal value, decimal addend, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException(nameof(count), count);
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return value += addend;
			}
		}
	}
}