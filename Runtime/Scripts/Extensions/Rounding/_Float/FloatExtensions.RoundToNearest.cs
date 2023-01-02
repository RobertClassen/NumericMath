namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static float RoundToNearest(this float value, double stepSize)
		{
			if(stepSize <= Int.Zero)
			{
				throw new ArgumentLessEqualsZeroException(nameof(stepSize));
			}
			double fraction = value / stepSize;
			return (float)(fraction.Nearest(Math.Floor(fraction), Math.Ceiling(fraction)) * stepSize);
		}
	}
}