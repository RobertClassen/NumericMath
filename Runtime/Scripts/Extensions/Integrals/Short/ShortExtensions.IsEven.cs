namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ShortExtensions
	{
		public static bool IsEven(this short value)
		{
			return value % (short)Numeric.Base.Binary == Int.Zero;
		}
	}
}