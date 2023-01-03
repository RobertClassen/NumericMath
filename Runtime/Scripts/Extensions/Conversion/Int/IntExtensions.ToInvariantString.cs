namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class IntExtensions
	{
		public static string ToInvariantString(this int value, string format = null)
		{
			return value.ToString(format, Culture.Invariant);
		}
	}
}