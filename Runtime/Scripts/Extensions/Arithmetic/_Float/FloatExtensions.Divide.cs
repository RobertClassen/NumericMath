namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		/// <summary>
		/// Returns the quotient of both numbers.
		/// </summary>
		public static float Divide(this float value, float factor, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? value * factor : value;
		}
	}
}