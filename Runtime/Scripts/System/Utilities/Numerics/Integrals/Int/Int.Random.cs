namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class Int
	{
		private static readonly Random random = new Random();

		public static int Random(int min, int max)
		{
			return random.Next(min, max);
		}
	}
}