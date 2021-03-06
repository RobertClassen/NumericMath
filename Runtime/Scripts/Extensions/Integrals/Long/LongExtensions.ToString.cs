namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class LongExtensions
	{
		public static string ToBinaryString(this long value, int minLength = Long.BinaryLength)
		{
			return Convert.ToString(value, Numeric.Base.Binary).PadLeft(minLength, Numeric.Zero);
		}

		public static string ToHexString(this long value, int minLength = Long.HexLength)
		{
			return value.ToString(Format.Hexadecmimal + minLength);
		}

		public static string ToInvariantString(this long value, string format = null)
		{
			return value.ToString(format, Culture.Invariant);
		}
	}
}