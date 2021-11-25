namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static double Subtract(this double start, double increment)
		{
			return start - increment;
		}

		public static IEnumerable<double> Subtract(this double start, double increment, int count)
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