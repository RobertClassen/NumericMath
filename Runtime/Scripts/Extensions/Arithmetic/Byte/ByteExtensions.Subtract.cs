namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		/// <summary>
		/// Returns the difference of both numbers.
		/// </summary>
		public static byte Subtract(this byte value, byte subtrahend, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? (byte)(value - subtrahend) : value;
		}
	}
}