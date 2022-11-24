namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Numerics;

	public static partial class LongExtensions
	{
		public static BigInteger BigMul(this long value, long factor)
		{
			return new BigInteger(value) * new BigInteger(factor);
		}
	}
}