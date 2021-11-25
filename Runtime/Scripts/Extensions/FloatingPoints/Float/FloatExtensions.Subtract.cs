namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Subtract(this float value, float subtrahend)
		{
			return value - subtrahend;
		}

		public static IEnumerable<float> Subtract(this float value, float subtrahend, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException(nameof(count), count);
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return value -= subtrahend;
			}
		}
	}
}