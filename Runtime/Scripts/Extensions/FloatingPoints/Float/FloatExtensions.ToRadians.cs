namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static float ToRadians(this float degrees, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? degrees * Float.Deg2Rad : degrees;
		}
	}
}