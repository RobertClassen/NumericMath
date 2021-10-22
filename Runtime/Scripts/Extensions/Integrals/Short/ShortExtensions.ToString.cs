namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ShortExtensions
	{
		public static string ToBinaryString(this short value, int minLength = Short.BitCount)
		{
			return Convert.ToString(value, (int)Numeric.Base.Binary).PadLeft(minLength, Numeric.Zero);
		}

		public static string ToHexString(this short value, int minLength = Short.HexLength)
		{
			return value.ToString(Format.Hexadecmimal + minLength);
		}

		public static string ToInvariantString(this short value, string format = null)
		{
			return value.ToString(format, Culture.Invariant);
		}
	}
}