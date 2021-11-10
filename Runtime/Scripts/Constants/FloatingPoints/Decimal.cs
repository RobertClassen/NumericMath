namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Decimal
	{
		public const byte BinaryLength = (byte)(sizeof(decimal) * Byte.BinaryLength);

		public const decimal Zero = Byte.Zero;
		public const decimal One = Byte.One;

		public const decimal OneHalf = One / (One + One);

		public const decimal FullCircleDegrees = 360m;
		public const decimal Rad2Deg = FullCircleDegrees * OneHalf / (decimal)Math.PI;
		public const decimal Deg2Rad = One / Rad2Deg;
	}
}