namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ShortExtensions
	{
		public static string ToInvariantString(this short value, string format = null)
		{
			return value.ToString(format, Culture.Invariant);
		}
	}
}