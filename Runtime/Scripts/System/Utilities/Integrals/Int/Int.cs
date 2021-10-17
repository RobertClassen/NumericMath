namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class Int
	{
		public const byte BitCount = sizeof(int) * Byte.BitCount;
		public const int HexLength = BitCount >> (One + One);

		public const int Zero = Byte.Zero;
		public const int One = Byte.One;
		public const int Hundred = Byte.Hundred;
	}
}