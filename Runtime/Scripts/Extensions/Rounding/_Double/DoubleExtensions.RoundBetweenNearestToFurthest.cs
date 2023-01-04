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
		/// between the nearest and furthest value 
		/// of the next-lower and next-higher value 
		/// at the specified <c>stepSize</c>.
		/// </summary>
		public static double RoundBetweenNearestToFurthest(this double value, double stepSize, double percent, 
			bool clamp = Numeric.IsLerpClampedDefault)
		{
			if(stepSize.IsZero())
			{
				throw new DivideByZeroException(nameof(stepSize));
			}
			double fraction = value / stepSize;
			double floor = Math.Floor(fraction);
			double ceiling = Math.Ceiling(fraction);
			return percent.Lerp(fraction.Nearest(floor, ceiling), fraction.Furthest(ceiling, floor), clamp) * stepSize;
		}
	}
}