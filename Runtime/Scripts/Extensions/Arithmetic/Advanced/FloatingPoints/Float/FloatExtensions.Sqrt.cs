namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static double Sqrt(this float value)
		{
			return Math.Sqrt(value);
		}

		public static float SqrtF(this float value)
		{
			return (float)Math.Sqrt(value);
		}
	}
}