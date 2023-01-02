namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class IntExtensions
	{
		public static int RoundToFurthest(this int value, double stepSize, 
			MidpointRounding mode = MidpointRounding.ToEven)
		{
			if(stepSize <= Int.Zero)
			{
				throw new ArgumentLessEqualsZeroException(nameof(stepSize));
			}
			double fraction = value / stepSize;
			return (int)Math.Round(fraction.Furthest(Math.Floor(fraction), Math.Ceiling(fraction)) * stepSize, mode);
		}
	}
}