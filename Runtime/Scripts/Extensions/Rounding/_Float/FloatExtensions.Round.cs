namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Round(this float value, int digits = Int.Zero, 
			MidpointRounding mode = MidpointRounding.ToEven)
		{
			return (float)Math.Round(value, digits, mode);
		}
	}
}