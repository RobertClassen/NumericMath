namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Asin(this float value)
		{
			return (float)Math.Asin(value);
		}

		public static float Sin(this float value)
		{
			return (float)Math.Sin(value);
		}

		public static float Sinh(this float value)
		{
			return (float)Math.Sinh(value);
		}
	}
}