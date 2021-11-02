namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		public static int Pow(this int value, int exponent)
		{
			return (int)Math.Pow(value, exponent);
		}
	}
}