namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static double HarmonicMean(this IEnumerable<double> values)
		{
			double sum = Double.Zero;
			int count = Int.Zero;
			foreach(double value in values)
			{
				sum += Double.One / value;
				count++;
			}
			return count / sum;
		}
	}
}