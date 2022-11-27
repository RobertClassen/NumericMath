namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
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
	}
}