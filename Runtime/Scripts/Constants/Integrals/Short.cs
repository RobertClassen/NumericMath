namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Short
	{
		public const byte BinaryLength = sizeof(short) * Byte.BinaryLength;
		public const byte HexLength = BinaryLength >> (One + One);

		public const short Zero = Byte.Zero;
		public const short One = Byte.One;
	}
}