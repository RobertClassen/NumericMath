namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;
	using Core;

	public static partial class FloatExtensions
	{
		public static string ToInvariantString(this float value, string format = null)
		{
			return value.ToString(format, Culture.Invariant);
		}

		public static string ToPercentString(this float value, CultureInfo cultureInfo = null)
		{
			return (value * Float.Hundred).ToString(cultureInfo ?? Culture.Invariant) + Numeric.Percent;
		}
	}
}