namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		public static byte DivRem(this byte dividend, byte divisor, out byte remainder)
		{
			int rem;
			byte result = (byte)Math.DivRem(dividend, divisor, out rem);
			remainder = (byte)rem;
			return result;
		}
	}
}