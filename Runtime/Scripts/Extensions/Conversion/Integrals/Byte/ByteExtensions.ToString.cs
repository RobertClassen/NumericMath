namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ByteExtensions
	{
		public static string ToBinaryString(this byte value, int minLength = Byte.BinaryLength)
		{
			return Convert.ToString(value, Numeric.Base.Binary).PadLeft(minLength, Numeric.Zero);
		}

		public static string ToHexString(this byte value, int minLength = Byte.HexLength)
		{
			return value.ToString(Format.Hexadecmimal + minLength);
		}

		public static string ToInvariantString(this byte value, string format = null)
		{
			return value.ToString(format, Culture.Invariant);
		}
	}
}