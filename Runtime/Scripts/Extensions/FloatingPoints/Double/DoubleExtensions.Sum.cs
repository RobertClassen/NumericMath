namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static double Sum(this IEnumerable<double> values)
		{
			double sum = Double.Zero;
			foreach(double value in values)
			{
				sum += value;
			}
			return sum;
		}
	}
}