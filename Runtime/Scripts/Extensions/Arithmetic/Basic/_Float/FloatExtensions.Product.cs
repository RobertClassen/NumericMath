namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Product(this IEnumerable<float> values)
		{
			float product = Float.One;
			foreach(float value in values)
			{
				product *= value;
			}
			return product;
		}
	}
}