namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		public static decimal Round(this decimal value)
		{
			return Math.Round(value);
		}

		public static long RoundToLong(this decimal value)
		{
			return (long)Math.Round(value);
		}

		public static decimal RoundToMid(this decimal value)
		{
			return Math.Round(value) + Decimal.OneHalf;
		}
	}
}