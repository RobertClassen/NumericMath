namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		/// <summary>
		/// Returns the product of both numbers.
		/// </summary>
		public static long Multiply(this long value, long factor, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? value * factor : value;
		}
	}
}