namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		public static short ArithmeticMean(this IEnumerable<short> values)
		{
			double sum = Double.Zero;
			int count = Int.Zero;
			foreach(short value in values)
			{
				sum += value;
				count++;
			}
			return (short)(sum / (double)count);
		}

		public static short GeometricMean(this IEnumerable<short> values)
		{
			double sum = Double.One;
			int count = Int.Zero;
			foreach(short value in values)
			{
				sum *= value;
				count++;
			}
			return (short)sum.Root(count);
		}

		public static short HarmonicMean(this IEnumerable<short> values)
		{
			double sum = Double.Zero;
			int count = Int.Zero;
			foreach(short value in values)
			{
				sum += Double.One / (double)value;
				count++;
			}
			return (short)(count / sum);
		}
	}
}