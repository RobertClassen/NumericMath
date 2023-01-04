namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static int FloorToInt(this float value, double stepSize = Double.One)
		{
			return (int)value.Floor(stepSize);
		}
	}
}