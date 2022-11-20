namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		public static byte Product(this IEnumerable<byte> values)
		{
			byte product = Byte.One;
			foreach(byte value in values)
			{
				product *= value;
			}
			return product;
		}
	}
}