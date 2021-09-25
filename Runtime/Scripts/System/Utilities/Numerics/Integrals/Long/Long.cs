namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class Long
	{
		public const byte BitCount = sizeof(long) * Byte.BitCount;
		public const int HexLength = BitCount >> (int)(One + One);

		public const long Zero = Byte.Zero;
		public const long One = Byte.One;
		public const long Hundred = Byte.Hundred;
	}
}