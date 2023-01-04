namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static double RoundToMid(this double value, double stepSize)
		{
			return value.RoundBetweenMinToMax(stepSize, Double.OneHalf);
		}
	}
}