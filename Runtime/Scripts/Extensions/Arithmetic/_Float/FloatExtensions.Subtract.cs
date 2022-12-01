namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		/// <summary>
		/// Returns the difference of both numbers.
		/// </summary>
		public static float Subtract(this float value, float subtrahend, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? value - subtrahend : value;
		}
	}
}