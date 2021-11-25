namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		public static int Subtract(this int start, int increment)
		{
			return start - increment;
		}

		public static IEnumerable<int> Subtract(this int start, int increment, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException(nameof(count), count);
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return start -= increment;
			}
		}
	}
}