namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class BoolExtensions
	{
		public static int ToInt(this bool value)
		{
			return value ? Int.One : Int.Zero;
		}

		public static string ToBinaryString(this bool value)
		{
			return value.ToInt().ToString();
		}

		public static string ToInvariantString(this bool value)
		{
			return value.ToString(Culture.Invariant);
		}
	}
}