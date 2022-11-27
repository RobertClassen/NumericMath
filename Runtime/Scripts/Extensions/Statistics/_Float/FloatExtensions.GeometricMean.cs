namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
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
	}
}