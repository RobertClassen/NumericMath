namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class DoubleExtensions
	{
		public static string ToInvariantString(this double value, string format = String.Null)
		{
			return value.ToString(format, Culture.Invariant);
		}

		public static string ToPercentString(this double value, CultureInfo cultureInfo = null)
		{
			return (value * Double.Hundred).ToString(cultureInfo ?? Culture.Invariant) + String.Percent;
		}
	}
}