namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		public static double MidRange(this IEnumerable<int> values)
		{
			int min = int.MaxValue;
			int max = int.MinValue;
			foreach(int value in values)
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