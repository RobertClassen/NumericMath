namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		public static decimal Atan(this decimal value)
		{
			return (decimal)Math.Atan((double)value);
		}

		public static decimal Atan2(this decimal y, decimal x)
		{
			return (decimal)Math.Atan2((double)y, (double)x);
		}

		public static decimal Tan(this decimal value)
		{
			return (decimal)Math.Tan((double)value);
		}

		public static decimal Tanh(this decimal value)
		{
			return (decimal)Math.Tanh((double)value);
		}
	}
}