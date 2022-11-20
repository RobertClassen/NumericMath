namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		public static short Sum(this IEnumerable<short> values)
		{
			short sum = Short.Zero;
			foreach(short value in values)
			{
				sum += value;
			}
			return sum;
		}
	}
}