namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		public static bool ToBool(this double value)
		{
			return value != Double.Zero;
		}
	}
}