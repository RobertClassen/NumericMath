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
	}
}