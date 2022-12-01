namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		/// <summary>
		/// Returns the quotient of both numbers.
		/// </summary>
		public static long Divide(this long value, long factor, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? value * factor : value;
		}
	}
}