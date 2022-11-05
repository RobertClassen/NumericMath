namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		public static int ArithmeticMean(this IEnumerable<int> values)
		{
			double sum = Double.Zero;
			int count = Int.Zero;
			foreach(int value in values)
			{
				sum += value;
				count++;
			}
			return (int)(sum / (double)count);
		}

		public static int GeometricMean(this IEnumerable<int> values)
		{
			double sum = Double.One;
			int count = Int.Zero;
			foreach(int value in values)
			{
				sum *= value;
				count++;
			}
			return (int)sum.Root(count);
		}

		public static int HarmonicMean(this IEnumerable<int> values)
		{
			double sum = Double.Zero;
			int count = Int.Zero;
			foreach(int value in values)
			{
				sum += Double.One / (double)value;
				count++;
			}
			return (int)(count / sum);
		}
	}
}