namespace NumericMath
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

		public static string ToPercentString(this float value, int decimals = 2, CultureInfo cultureInfo = null)
		{
			return value.ToString(Format.Percent + decimals, cultureInfo ?? Culture.Invariant);
		}
	}
}