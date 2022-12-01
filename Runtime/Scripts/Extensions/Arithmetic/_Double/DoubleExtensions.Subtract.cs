namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		/// <summary>
		/// Returns the difference of both numbers.
		/// </summary>
		public static double Subtract(this double value, double subtrahend, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? value - subtrahend : value;
		}
	}
}