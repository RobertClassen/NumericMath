namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		public static decimal Sqrt(this decimal value)
		{
			return (decimal)Math.Sqrt((double)value);
		}
	}
}