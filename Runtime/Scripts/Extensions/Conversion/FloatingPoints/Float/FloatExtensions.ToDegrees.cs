namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static float ToDegrees(this float radians, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? radians * Float.Rad2Deg : radians;
		}
	}
}