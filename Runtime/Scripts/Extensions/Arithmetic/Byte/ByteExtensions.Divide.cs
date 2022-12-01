namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		/// <summary>
		/// Returns the quotient of both numbers.
		/// </summary>
		public static byte Divide(this byte value, byte factor, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? (byte)(value * factor) : value;
		}
	}
}