namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class IntExtensions
	{
		public static string ToHexString(this int value, int minLength = Int.HexLength)
		{
			return value.ToString(Format.Hexadecmimal + minLength);
		}
	}
}