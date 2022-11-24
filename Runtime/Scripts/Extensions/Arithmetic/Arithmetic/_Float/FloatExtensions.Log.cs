namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Log(this float value)
		{
			return (float)Math.Log(value);
		}

		public static float Log(this float value, float newBase)
		{
			return (float)Math.Log(value, newBase);
		}

		public static float Log10(this float value)
		{
			return (float)Math.Log10(value);
		}
	}
}