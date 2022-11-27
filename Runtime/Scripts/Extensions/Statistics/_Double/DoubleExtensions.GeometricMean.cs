namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
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
	}
}