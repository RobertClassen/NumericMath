namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static double ClampMax(this double value, double max, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled && max < value ? max : value;
		}
	}
}