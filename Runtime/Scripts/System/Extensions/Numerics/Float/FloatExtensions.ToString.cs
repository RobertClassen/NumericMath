namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;

	public static partial class FloatExtensions
	{
		public static string ToInvariantString(this float value, string format = String.Null)
		{
			return value.ToString(format, Culture.Invariant);
		}

		public static string ToPercentString(this float value, CultureInfo cultureInfo = null)
		{
			return (value * Float.Hundred).ToString(cultureInfo ?? Culture.Invariant) + String.Percent;
		}
	}
}