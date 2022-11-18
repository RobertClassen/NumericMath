namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ByteExtensions
	{
		public static bool IsEven(this byte value)
		{
			return value % (byte)Numeric.Base.Binary == Byte.Zero;
		}
	}
}