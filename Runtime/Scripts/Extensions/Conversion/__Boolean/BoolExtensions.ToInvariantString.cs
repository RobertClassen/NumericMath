namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class BoolExtensions
	{
		public static string ToInvariantString(this bool value)
		{
			return value.ToString(Culture.Invariant);
		}
	}
}