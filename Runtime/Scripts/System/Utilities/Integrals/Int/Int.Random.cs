namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class Int
	{
		public static int Random(int min, int max)
		{
			return Numeric.Random.Next(min, max);
		}
	}
}