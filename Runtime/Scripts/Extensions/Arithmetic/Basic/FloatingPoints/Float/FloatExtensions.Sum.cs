namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Sum(this IEnumerable<float> values)
		{
			float sum = Float.Zero;
			foreach(float value in values)
			{
				sum += value;
			}
			return sum;
		}
	}
}