namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class Float
	{
		public static float Random(int min, int max)
		{
			return Int.Random(min, max);
		}

		public static float Random(int min, int max, int decimals)
		{
			float magnitude = (float)Math.Pow((double)Numeric.Base.Decimal, decimals);
			return Random(min * (int)magnitude, max * (int)magnitude) / magnitude;
		}
	}
}