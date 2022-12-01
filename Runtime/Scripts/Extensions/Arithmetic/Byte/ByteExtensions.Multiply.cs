namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		/// <summary>
		/// Returns the product of both numbers.
		/// </summary>
		public static byte Multiply(this byte value, byte factor, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? (byte)(value * factor) : value;
		}
	}
}