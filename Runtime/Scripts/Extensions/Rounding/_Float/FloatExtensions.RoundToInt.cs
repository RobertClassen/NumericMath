namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static int RoundToInt(this float value, MidpointRounding mode = MidpointRounding.ToEven)
		{
			return (int)Math.Round(value, mode);
		}
	}
}