namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DecimalExtensions
	{
		public static decimal ToRadians(this decimal degrees, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? degrees * Decimal.Deg2Rad : degrees;
		}
	}
}