namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
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