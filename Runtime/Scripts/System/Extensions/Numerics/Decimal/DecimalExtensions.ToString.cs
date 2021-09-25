namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class DecimalExtensions
	{
		public static string ToInvariantString(this decimal value, string format = String.Null)
		{
			return value.ToString(format, Culture.Invariant);
		}

		public static string ToPercentString(this decimal value, CultureInfo cultureInfo = null)
		{
			return (value * Decimal.Hundred).ToString(cultureInfo ?? Culture.Invariant) + String.Percent;
		}
	}
}