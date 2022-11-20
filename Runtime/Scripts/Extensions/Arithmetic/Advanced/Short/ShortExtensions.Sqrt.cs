namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		public static double Sqrt(this short value)
		{
			return Math.Sqrt(value);
		}

		public static float SqrtF(this short value)
		{
			return (float)Math.Sqrt(value);
		}
	}
}