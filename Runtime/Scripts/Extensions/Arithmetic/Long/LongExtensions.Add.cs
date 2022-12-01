namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		/// <summary>
		/// Returns the sum of both numbers.
		/// </summary>
		public static long Add(this long value, long addend, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? value + addend : value;
		}
	}
}