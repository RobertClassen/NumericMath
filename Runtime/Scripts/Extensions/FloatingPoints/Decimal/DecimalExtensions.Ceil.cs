namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		public static decimal Ceil(this decimal value)
		{
			return Math.Ceiling(value);
		}

		public static long CeilToInt(this decimal value)
		{
			return (long)value.Ceil();
		}
	}
}