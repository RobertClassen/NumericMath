namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Round(this float value)
		{
			return (float)Math.Round(value);
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