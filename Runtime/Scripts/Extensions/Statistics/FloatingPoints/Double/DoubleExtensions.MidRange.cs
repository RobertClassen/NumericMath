namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static double MidRange(this IEnumerable<double> values)
		{
			double min = double.MaxValue;
			double max = double.MinValue;
			foreach(double value in values)
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