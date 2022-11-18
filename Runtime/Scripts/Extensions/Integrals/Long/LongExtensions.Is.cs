namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class LongExtensions
	{
		public static bool IsEven(this long value)
		{
			return value % (long)Numeric.Base.Binary == Long.Zero;
		}

		public static bool IsOdd(this long value)
		{
			return value % (long)Numeric.Base.Binary != Long.Zero;
		}
	}
}