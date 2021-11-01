namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DecimalExtensions
	{
		public static decimal ToDegrees(this decimal radians, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? radians * Decimal.Rad2Deg : radians;
		}
	}
}