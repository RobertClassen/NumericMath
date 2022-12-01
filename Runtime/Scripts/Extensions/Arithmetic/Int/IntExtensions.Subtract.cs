namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		/// <summary>
		/// Returns the difference of both numbers.
		/// </summary>
		public static int Subtract(this int value, int subtrahend, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? value - subtrahend : value;
		}
	}
}