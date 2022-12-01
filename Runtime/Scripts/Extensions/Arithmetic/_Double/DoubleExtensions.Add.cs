namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		/// <summary>
		/// Returns the sum of both numbers.
		/// </summary>
		public static double Add(this double value, double addend, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? value + addend : value;
		}
	}
}