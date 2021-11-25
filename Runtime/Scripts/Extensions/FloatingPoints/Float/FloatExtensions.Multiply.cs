namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Multiply(this float value, float factor)
		{
			return value * factor;
		}

		public static IEnumerable<float> Multiply(this float value, float factor, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException(nameof(count), count);
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return value *= factor;
			}
		}
	}
}