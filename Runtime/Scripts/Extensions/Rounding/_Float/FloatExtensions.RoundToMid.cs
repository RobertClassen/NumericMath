namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static float RoundToMid(this float value, double stepSize, 
			MidpointRounding mode = MidpointRounding.ToEven)
		{
			if(stepSize <= Int.Zero)
			{
				throw new ArgumentLessEqualsZeroException(nameof(stepSize));
			}
			double fraction = value / stepSize;
			return (float)Math.Round(Double.OneHalf.Lerp(Math.Floor(fraction), Math.Ceiling(fraction)) * stepSize, mode);
		}
	}
}