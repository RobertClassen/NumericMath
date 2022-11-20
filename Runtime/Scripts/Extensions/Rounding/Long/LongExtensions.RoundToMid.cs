namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class LongExtensions
	{
		public static long RoundToMid(this long value, double stepSize, MidpointRounding mode = MidpointRounding.ToEven)
		{
			if(stepSize <= Int.Zero)
			{
				throw new ArgumentLessEqualsZeroException(nameof(stepSize));
			}
			double fraction = value / stepSize;
			return (long)Math.Round(Double.OneHalf.Lerp(Math.Floor(fraction), Math.Ceiling(fraction)) * stepSize, mode);
		}
	}
}