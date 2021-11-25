namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static IEnumerable<float> Range(this float start, int count, float increment = Float.One)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException(nameof(count), count);
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return start;
				start += increment;
			}
		}
	}
}