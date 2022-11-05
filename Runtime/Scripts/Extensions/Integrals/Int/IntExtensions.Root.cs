namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		public static int Root(this int value, double root)
		{
			return (int)Math.Pow(value, Double.One / root);
		}
	}
}