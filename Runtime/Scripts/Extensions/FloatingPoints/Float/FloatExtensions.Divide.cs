namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Divide(this float value, float divisor)
		{
			return value / divisor;
		}

		public static IEnumerable<float> Divide(this float value, float divisor, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException(nameof(count), count);
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return value /= divisor;
			}
		}
	}
}