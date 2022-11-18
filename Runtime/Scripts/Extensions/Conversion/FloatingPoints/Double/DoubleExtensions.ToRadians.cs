namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static double ToRadians(this double degrees, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? degrees * Double.Deg2Rad : degrees;
		}
	}
}