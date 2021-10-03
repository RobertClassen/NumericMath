namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		public static decimal Log(this decimal value)
		{
			return (decimal)Math.Log((double)value);
		}

		public static decimal Log(this decimal value, decimal newBase)
		{
			return (decimal)Math.Log((double)value, (double)newBase);
		}

		public static decimal Log10(this decimal value)
		{
			return (decimal)Math.Log10((double)value);
		}
	}
}