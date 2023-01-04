namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Ceil(this float value, double stepSize = Double.One)
		{
			if(stepSize.IsZero())
			{
				throw new DivideByZeroException(nameof(stepSize));
			}
			return (float)(Math.Ceiling(value / stepSize) * stepSize);
		}
	}
}