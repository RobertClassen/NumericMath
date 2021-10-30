namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		public static bool ToBool(this decimal value)
		{
			return value != Decimal.Zero;
		}
	}
}