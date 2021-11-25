namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Subtract(this float start, float increment)
		{
			return start - increment;
		}

		public static IEnumerable<float> Subtract(this float start, float increment, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException();
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return start;
				start -= increment;
			}
		}
	}
}