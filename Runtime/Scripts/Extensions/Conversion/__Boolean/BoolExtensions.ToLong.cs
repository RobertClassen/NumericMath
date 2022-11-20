namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class BoolExtensions
	{
		public static long ToLong(this bool value)
		{
			return value ? Long.One : Long.Zero;
		}
	}
}