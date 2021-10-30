namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Byte
	{
		public const byte BinaryLength = sizeof(byte) * 8;
		public const byte HexLength = BinaryLength >> (One + One);

		public const byte Zero = One - One;
		public const byte One = 1;
	}
}