namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		public static int Add(this int value, int increment)
		{
			return value + increment;
		}

		public static IEnumerable<int> Add(this int value, int increment, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException(nameof(count), count);
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return value += increment;
			}
		}
	}
}