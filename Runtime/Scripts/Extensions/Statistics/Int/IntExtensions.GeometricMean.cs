namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
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
	}
}