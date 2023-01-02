namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static double RoundToNearest(this double value, double stepSize)
		{
			if(stepSize <= Int.Zero)
			{
				throw new ArgumentLessEqualsZeroException(nameof(stepSize));
			}
			double fraction = value / stepSize;
			return fraction.Nearest(Math.Floor(fraction), Math.Ceiling(fraction)) * stepSize;
		}
	}
}