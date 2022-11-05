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

		public static double GeometricMean(this IEnumerable<double> values)
		{
			double sum = Double.One;
			int count = Int.Zero;
			foreach(double value in values)
			{
				sum *= value;
				count++;
			}
			return sum.Root(count);
		}

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