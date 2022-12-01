namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		/// <summary>
		/// Returns the difference of both numbers.
		/// </summary>
		public static short Subtract(this short value, short subtrahend, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? (short)(value - subtrahend) : value;
		}
	}
}