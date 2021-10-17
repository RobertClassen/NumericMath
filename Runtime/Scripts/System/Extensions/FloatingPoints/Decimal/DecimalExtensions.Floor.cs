namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		public static decimal Floor(this decimal value)
		{
			return Math.Floor(value);
		}

		public static long FloorToInt(this decimal value)
		{
			return (long)value.Floor();
		}
	}
}