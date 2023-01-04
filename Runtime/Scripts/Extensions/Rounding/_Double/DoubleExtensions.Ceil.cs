namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static double Ceil(this double value, double stepSize = Double.One)
		{
			if(stepSize.IsZero())
			{
				throw new DivideByZeroException(nameof(stepSize));
			}
			return Math.Ceiling(value / stepSize) * stepSize;
		}
	}
}