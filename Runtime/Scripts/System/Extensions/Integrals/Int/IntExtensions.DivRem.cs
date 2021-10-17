namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		public static int DivRem(this int dividend, int divisor, out int remainder)
		{
			return Math.DivRem(dividend, divisor, out remainder);
		}
	}
}