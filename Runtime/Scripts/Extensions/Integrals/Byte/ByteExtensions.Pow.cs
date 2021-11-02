namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		public static byte Pow(this byte value, byte exponent)
		{
			return (byte)Math.Pow(value, exponent);
		}
	}
}