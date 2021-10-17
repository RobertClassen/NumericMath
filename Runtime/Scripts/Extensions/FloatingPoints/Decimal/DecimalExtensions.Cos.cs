namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		public static decimal Acos(this decimal value)
		{
			return (decimal)Math.Acos((double)value);
		}

		public static decimal Cos(this decimal value)
		{
			return (decimal)Math.Cos((double)value);
		}

		public static decimal Cosh(this decimal value)
		{
			return (decimal)Math.Cosh((double)value);
		}
	}
}