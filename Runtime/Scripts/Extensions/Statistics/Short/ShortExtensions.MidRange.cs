namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		public static double MidRange(this IEnumerable<short> values)
		{
			short min = short.MaxValue;
			short max = short.MinValue;
			foreach(short value in values)
			{
				if(value < min)
				{
					min = value;
				}
				if(value > max)
				{
					max = value;
				}
			}
			return (min + max) * Double.OneHalf;
		}
	}
}