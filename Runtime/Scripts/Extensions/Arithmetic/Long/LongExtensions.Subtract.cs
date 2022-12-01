namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		/// <summary>
		/// Returns the difference of both numbers.
		/// </summary>
		public static long Subtract(this long value, long subtrahend, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? value - subtrahend : value;
		}
	}
}