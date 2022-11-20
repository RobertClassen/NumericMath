namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		/// <summary>
		/// Returns the difference between the largest and smallest value.
		/// </summary>
		public static byte RangeMagnitude(this byte value, byte other)
		{
			return (byte)(value < other ? other - value : value - other);
		}
	}
}