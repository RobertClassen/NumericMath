namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ByteExtensions
	{
		public static string ToHexString(this byte value, int minLength = Byte.HexLength)
		{
			return value.ToString(Format.Hexadecmimal + minLength);
		}
	}
}