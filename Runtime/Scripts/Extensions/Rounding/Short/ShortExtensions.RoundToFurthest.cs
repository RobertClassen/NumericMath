namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ShortExtensions
	{
		public static short RoundToFurthest(this short value, double stepSize, MidpointRounding mode = MidpointRounding.ToEven)
		{
			if(stepSize <= Int.Zero)
			{
				throw new ArgumentLessEqualsZeroException(nameof(stepSize));
			}
			double fraction = value / stepSize;
			return (short)Math.Round(fraction.Furthest(Math.Floor(fraction), Math.Ceiling(fraction)) * stepSize, mode);
		}
	}
}