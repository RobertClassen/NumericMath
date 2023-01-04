namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		/// <summary>
		/// Rounds the value to the specified percentage 
		/// between the next-lower and next-higher value 
		/// at the specified <c>stepSize</c>.
		/// </summary>
		public static double RoundBetweenMinToMax(this double value, double stepSize, double percent, 
			bool clamp = Numeric.IsLerpClampedDefault)
		{
			if(stepSize.IsZero())
			{
				throw new DivideByZeroException(nameof(stepSize));
			}
			double fraction = value / stepSize;
			return percent.Lerp(Math.Floor(fraction), Math.Ceiling(fraction), clamp) * stepSize;
		}
	}
}