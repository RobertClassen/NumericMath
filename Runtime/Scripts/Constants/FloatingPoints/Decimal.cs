namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Decimal
	{
		public const byte BitCount = (byte)(sizeof(decimal) * Byte.BitCount);

		public const decimal Zero = Byte.Zero;
		public const decimal One = Byte.One;

		public const decimal OneHalf = One / (One + One);
	}
}