namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ByteExtensions
	{
		public static string ToBinaryString(this byte value, int minLength = Byte.BitCount)
		{
			return Convert.ToString(value, (int)Numeric.Base.Binary).PadLeft(minLength, Char.Zero);
		}

		public static string ToHexString(this byte value, int minLength = Byte.HexLength)
		{
			return value.ToString("X" + minLength);
		}

		public static string ToInvariantString(this byte value, string format = String.Null)
		{
			return value.ToString(format, Culture.Invariant);
		}
	}
}