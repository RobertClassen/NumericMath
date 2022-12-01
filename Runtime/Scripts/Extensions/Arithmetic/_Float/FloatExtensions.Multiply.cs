namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		/// <summary>
		/// Returns the product of both numbers.
		/// </summary>
		public static float Multiply(this float value, float factor, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? value * factor : value;
		}
	}
}