namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		public static long Product(this IEnumerable<long> values)
		{
			long product = Long.One;
			foreach(long value in values)
			{
				product *= value;
			}
			return product;
		}
	}
}