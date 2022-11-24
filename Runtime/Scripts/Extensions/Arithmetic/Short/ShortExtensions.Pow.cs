namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		public static short Pow(this short value, double exponent)
		{
			return (short)Math.Pow(value, exponent);
		}
	}
}