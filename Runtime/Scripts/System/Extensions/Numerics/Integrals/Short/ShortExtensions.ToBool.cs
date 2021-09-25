namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		public static string ToHexString(this short value, int minLength = Short.HexLength)
		{
			return value.ToString("X" + minLength);
		}
	}
}