namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;
	using Core;

	public static partial class DoubleExtensions
	{
		public static string ToInvariantString(this double value, string format = null)
		{
			return value.ToString(format, Culture.Invariant);
		}

		public static string ToPercentString(this double value, CultureInfo cultureInfo = null)
		{
			return (value * Double.Hundred).ToString(cultureInfo ?? Culture.Invariant) + Numeric.Percent;
		}
	}
}