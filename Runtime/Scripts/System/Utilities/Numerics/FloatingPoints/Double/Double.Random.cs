namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class Double
	{
		public static double Random(int min, int max)
		{
			return Float.Random(min, max);
		}

		public static double Random(int min, int max, int decimals)
		{
			double magnitude = Math.Pow((double)Numeric.Base.Decimal, decimals);
			return Random(min * (int)magnitude, max * (int)magnitude) / magnitude;
		}
	}
}