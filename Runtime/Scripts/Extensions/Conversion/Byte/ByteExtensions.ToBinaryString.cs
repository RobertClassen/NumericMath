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
	}
}