namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static double Ceil(this double value)
		{
			return Math.Ceiling(value);
		}

		public static long CeilToInt(this double value)
		{
			return (long)value.Ceil();
		}
	}
}