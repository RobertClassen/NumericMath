namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		public static byte Sum(this IEnumerable<byte> values)
		{
			byte sum = Byte.Zero;
			foreach(byte value in values)
			{
				sum += value;
			}
			return sum;
		}
	}
}