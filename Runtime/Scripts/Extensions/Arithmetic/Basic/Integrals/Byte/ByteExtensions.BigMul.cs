namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		public static short BigMul(this byte value, byte factor)
		{
			return (short)Math.BigMul(value, factor);
		}
	}
}