namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ShortExtensions
	{
		public static short RoundToMid(this short value, double stepSize, 
			MidpointRounding mode = MidpointRounding.ToEven)
		{
			return (short)Math.Round(((double)value).RoundBetweenMinToMax(stepSize, Double.OneHalf), mode);
		}
	}
}