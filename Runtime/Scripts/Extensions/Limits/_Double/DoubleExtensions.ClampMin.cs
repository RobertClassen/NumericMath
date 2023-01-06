namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static double ClampMin(this double value, double min, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled && value < min ? min : value;
		}
	}
}