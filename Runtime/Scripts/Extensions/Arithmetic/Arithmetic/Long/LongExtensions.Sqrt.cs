namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		public static double Sqrt(this long value)
		{
			return Math.Sqrt(value);
		}

		public static float SqrtF(this long value)
		{
			return (float)Math.Sqrt(value);
		}
	}
}