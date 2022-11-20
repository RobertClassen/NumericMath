namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		public static long BigMul(this int value, int factor)
		{
			return Math.BigMul(value, factor);
		}
	}
}