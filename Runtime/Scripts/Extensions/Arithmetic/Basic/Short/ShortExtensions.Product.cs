namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		public static short Product(this IEnumerable<short> values)
		{
			short product = Short.One;
			foreach(short value in values)
			{
				product *= value;
			}
			return product;
		}
	}
}