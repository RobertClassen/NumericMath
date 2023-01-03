namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ShortExtensions
	{
		public static string ToBinaryString(this short value, int minLength = Short.BinaryLength)
		{
			return Convert.ToString(value, Numeric.Base.Binary).PadLeft(minLength, Numeric.Zero);
		}
	}
}