namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		/// <summary>
		/// Returns the sum of both numbers.
		/// </summary>
		public static byte Add(this byte value, byte addend, bool isEnabled = Core.Function.IsEnabledDefault)
		{
			return isEnabled ? (byte)(value + addend) : value;
		}
	}
}