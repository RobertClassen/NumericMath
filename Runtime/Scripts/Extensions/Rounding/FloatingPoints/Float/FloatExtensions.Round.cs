namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Round(this float value, int digits = Int.Zero, MidpointRounding mode = MidpointRounding.ToEven)
		{
			return (float)Math.Round(value, digits, mode);
		}

		public static int RoundToInt(this float value)
		{
			return (int)Math.Round(value);
		}

		public static float RoundToMid(this float value)
		{
			return value.Round() + Float.OneHalf;
		}
	}
}