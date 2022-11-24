namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		public static short DivRem(this short dividend, short divisor, out short remainder)
		{
			int rem;
			short result = (short)Math.DivRem(dividend, divisor, out rem);
			remainder = (short)rem;
			return result;
		}
	}
}