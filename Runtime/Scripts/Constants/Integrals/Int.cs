namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Int
	{
		public const byte BinaryLength = sizeof(int) * Byte.BinaryLength;
		public const byte HexLength = BinaryLength >> (One + One);

		public const int Zero = Byte.Zero;
		public const int One = Byte.One;
	}
}