namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		public static long DivRem(this long dividend, long divisor, out long remainder)
		{
			return Math.DivRem(dividend, divisor, out remainder);
		}
	}
}