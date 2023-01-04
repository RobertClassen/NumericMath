namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static int CeilToInt(this float value, double stepSize = Double.One)
		{
			return (int)value.Ceil(stepSize);
		}
	}
}