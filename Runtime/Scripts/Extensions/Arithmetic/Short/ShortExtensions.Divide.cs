namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		/// <summary>
		/// Returns the quotient of both numbers.
		/// </summary>
		public static short Divide(this short value, short factor, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? (short)(value * factor) : value;
		}
	}
}