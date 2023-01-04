namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class IntExtensions
	{
		public static int RoundToMid(this int value, double stepSize, 
			MidpointRounding mode = MidpointRounding.ToEven)
		{
			return (int)Math.Round(((double)value).RoundBetweenMinToMax(stepSize, Double.OneHalf), mode);
		}
	}
}