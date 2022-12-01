namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		/// <summary>
		/// Returns the product of both numbers.
		/// </summary>
		public static int Multiply(this int value, int factor, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? value * factor : value;
		}
	}
}