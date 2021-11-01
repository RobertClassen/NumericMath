namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static double ToDegrees(this double radians, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? radians * Double.Rad2Deg : radians;
		}
	}
}