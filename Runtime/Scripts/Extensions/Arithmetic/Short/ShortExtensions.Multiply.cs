namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		/// <summary>
		/// Returns the product of both numbers.
		/// </summary>
		public static short Multiply(this short value, short factor, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? (short)(value * factor) : value;
		}
	}
}