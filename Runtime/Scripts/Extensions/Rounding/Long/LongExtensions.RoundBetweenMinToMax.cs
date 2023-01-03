namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class LongExtensions
	{
		/// <summary>
		/// Rounds the value to the specified percentage 
		/// between the next-lower and next-higher value 
		/// at the specified <c>stepSize</c>.
		/// </summary>
		public static long RoundBetweenMinToMax(this long value, double stepSize, double percent, 
			bool clamp = Numeric.IsLerpClampedDefault)
		{
			return (long)((double)value).RoundBetweenMinToMax(stepSize, percent, clamp);
		}
	}
}