namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		/// <summary>
		/// Returns the sum of both numbers.
		/// </summary>
		public static short Add(this short value, short addend, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? (short)(value + addend) : value;
		}
	}
}