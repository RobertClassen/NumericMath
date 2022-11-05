namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Root(this float value, double root)
		{
			return (float)Math.Pow(value, Double.One / root);
		}
	}
}