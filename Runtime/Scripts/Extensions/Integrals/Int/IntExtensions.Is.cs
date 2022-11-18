namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class IntExtensions
	{
		public static bool IsEven(this int value)
		{
			return value % (int)Numeric.Base.Binary == Int.Zero;
		}

		public static bool IsOdd(this int value)
		{
			return value % (int)Numeric.Base.Binary != Int.Zero;
		}
	}
}