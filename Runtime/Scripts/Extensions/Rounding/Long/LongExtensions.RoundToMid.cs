namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class LongExtensions
	{
		public static long RoundToMid(this long value, double stepSize, 
			MidpointRounding mode = MidpointRounding.ToEven)
		{
			return (long)Math.Round(((double)value).RoundBetweenMinToMax(stepSize, Double.OneHalf), mode);
		}
	}
}