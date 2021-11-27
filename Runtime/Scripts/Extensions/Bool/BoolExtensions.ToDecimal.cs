namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class BoolExtensions
	{
		public static decimal ToDecimal(this bool value)
		{
			return value ? Decimal.One : Decimal.Zero;
		}
	}
}