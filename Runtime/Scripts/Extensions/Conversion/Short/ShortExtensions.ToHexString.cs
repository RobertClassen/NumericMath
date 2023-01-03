namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ShortExtensions
	{
		public static string ToHexString(this short value, int minLength = Short.HexLength)
		{
			return value.ToString(Format.Hexadecmimal + minLength);
		}
	}
}