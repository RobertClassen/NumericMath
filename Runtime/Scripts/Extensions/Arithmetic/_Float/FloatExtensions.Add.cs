namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		/// <summary>
		/// Returns the sum of both numbers.
		/// </summary>
		public static float Add(this float value, float addend, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? value + addend : value;
		}
	}
}