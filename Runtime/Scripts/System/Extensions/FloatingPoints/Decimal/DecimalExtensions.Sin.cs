namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		public static decimal Asin(this decimal value)
		{
			return (decimal)Math.Asin((double)value);
		}

		public static decimal Sin(this decimal value)
		{
			return (decimal)Math.Sin((double)value);
		}

		public static decimal Sinh(this decimal value)
		{
			return (decimal)Math.Sinh((double)value);
		}
	}
}