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
	}
}