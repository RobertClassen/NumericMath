namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class Byte
	{
		public const byte BitCount = sizeof(byte) * 8;
		public const int HexLength = BitCount >> (One + One);

		public const byte Zero = One - One;
		public const byte One = 1;
		public const byte Hundred = 100;
	}
}