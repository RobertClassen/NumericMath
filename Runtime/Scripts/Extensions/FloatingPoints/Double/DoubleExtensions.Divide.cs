namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static double Divide(this double value, double divisor)
		{
			return value / divisor;
		}

		public static IEnumerable<double> Divide(this double value, double divisor, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException();
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return value /= divisor;
			}
		}
	}
}