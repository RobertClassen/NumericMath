namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class Decimal
	{
		private static readonly Random random = new Random();

		public static decimal Random(int min, int max)
		{
			return Int.Random(min, max);
		}

		public static decimal Random(int min, int max, int decimals)
		{
			decimal magnitude = (decimal)Math.Pow((double)Numeric.Base.Decimal, decimals);
			return Random(min * (int)magnitude, max * (int)magnitude) / magnitude;
		}
	}
}