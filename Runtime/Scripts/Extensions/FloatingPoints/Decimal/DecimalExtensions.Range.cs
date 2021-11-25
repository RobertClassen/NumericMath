namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		public static IEnumerable<decimal> Range(this decimal start, int count, decimal increment = Decimal.One)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException(nameof(count), count);
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return start;
				start += increment;
			}
		}
	}
}