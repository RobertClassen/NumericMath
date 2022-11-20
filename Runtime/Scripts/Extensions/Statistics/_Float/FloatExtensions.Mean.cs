namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float ArithmeticMean(this IEnumerable<float> values)
		{
			double sum = Double.Zero;
			int count = Int.Zero;
			foreach(float value in values)
			{
				sum += value;
				count++;
			}
			return (float)(sum / (double)count);
		}

		public static float GeometricMean(this IEnumerable<float> values)
		{
			double sum = Double.One;
			int count = Int.Zero;
			foreach(float value in values)
			{
				sum *= value;
				count++;
			}
			return (float)sum.Root(count);
		}

		public static float HarmonicMean(this IEnumerable<float> values)
		{
			double sum = Double.Zero;
			int count = Int.Zero;
			foreach(float value in values)
			{
				sum += Double.One / (double)value;
				count++;
			}
			return (float)(count / sum);
		}
	}
}