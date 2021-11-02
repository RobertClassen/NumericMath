namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		public static decimal Pow(this decimal value, decimal exponent)
		{
			return (decimal)Math.Pow((double)value, (double)exponent);
		}
	}
}