namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		public static int Subtract(this int value, int subtrahend)
		{
			return value - subtrahend;
		}

		public static IEnumerable<int> Subtract(this int value, int subtrahend, int count)
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