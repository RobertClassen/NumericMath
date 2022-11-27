namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static double ArithmeticMean(this IEnumerable<double> values)
		{
			double sum = Double.Zero;
			int count = Int.Zero;
			foreach(double value in values)
			{
				sum += value;
				count++;
			}
			return sum / (double)count;
		}
	}
}