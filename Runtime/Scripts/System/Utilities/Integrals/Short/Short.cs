namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class Short
	{
		public const byte BitCount = sizeof(short) * Byte.BitCount;
		public const int HexLength = BitCount >> (One + One);

		public const short Zero = Byte.Zero;
		public const short One = Byte.One;
		public const short Hundred = Byte.Hundred;
	}
}