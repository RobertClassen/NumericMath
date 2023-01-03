namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class LongExtensions
	{
		public static string ToHexString(this long value, int minLength = Long.HexLength)
		{
			return value.ToString(Format.Hexadecmimal + minLength);
		}
	}
}