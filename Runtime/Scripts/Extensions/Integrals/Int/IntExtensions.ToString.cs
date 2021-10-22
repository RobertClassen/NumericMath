namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class IntExtensions
	{
		public static string ToBinaryString(this int value, int minLength = Int.BitCount)
		{
			return Convert.ToString(value, (int)Numeric.Base.Binary).PadLeft(minLength, Numeric.Zero);
		}

		public static string ToHexString(this int value, int minLength = Int.HexLength)
		{
			return value.ToString(Format.Hexadecmimal + minLength);
		}

		public static string ToInvariantString(this int value, string format = null)
		{
			return value.ToString(format, Culture.Invariant);
		}
	}
}