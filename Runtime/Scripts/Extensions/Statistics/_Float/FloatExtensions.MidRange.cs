namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static double MidRange(this IEnumerable<float> values)
		{
			float min = float.MaxValue;
			float max = float.MinValue;
			foreach(float value in values)
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