namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
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