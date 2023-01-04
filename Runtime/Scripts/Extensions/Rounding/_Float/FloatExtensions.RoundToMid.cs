namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static float RoundToMid(this float value, double stepSize)
		{
			return (float)((double)value).RoundBetweenMinToMax(stepSize, Double.OneHalf);
		}
	}
}