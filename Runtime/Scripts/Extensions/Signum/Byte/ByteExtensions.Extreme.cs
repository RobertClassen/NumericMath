namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		/// <summary>
		/// Returns the extreme value with the same sign.
		/// </summary>
		public static byte Extreme(this byte value)
		{
			return byte.MaxValue;
		}
	}
}