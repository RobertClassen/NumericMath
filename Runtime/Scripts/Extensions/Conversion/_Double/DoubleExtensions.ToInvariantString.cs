namespace NumericMath
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
	}
}