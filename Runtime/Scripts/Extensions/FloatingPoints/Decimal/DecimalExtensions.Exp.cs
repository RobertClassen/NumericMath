namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		public static decimal Exp(this decimal value)
		{
			return (decimal)Math.Exp((double)value);
		}
	}
}