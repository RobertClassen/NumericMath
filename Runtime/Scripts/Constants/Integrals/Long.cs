namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Long
	{
		public const byte BinaryLength = sizeof(long) * Byte.BinaryLength;
		public const byte HexLength = BinaryLength >> (int)(One + One);

		public const long Zero = Byte.Zero;
		public const long One = Byte.One;
	}
}