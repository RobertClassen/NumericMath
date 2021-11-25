namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		public static int Divide(this int value, int divisor)
		{
			return value / divisor;
		}

		public static IEnumerable<int> Divide(this int value, int divisor, int count)
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