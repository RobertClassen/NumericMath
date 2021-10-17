namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static double Floor(this double value)
		{
			return Math.Floor(value);
		}

		public static long FloorToInt(this double value)
		{
			return (long)value.Floor();
		}
	}
}