namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Float
	{
		public const byte BinaryLength = sizeof(float) * Byte.BinaryLength;

		public const float Zero = Byte.Zero;
		public const float One = Byte.One;

		public const float OneHalf = (float)Decimal.OneHalf;

		public const float FullCircleDegrees = (float)Decimal.FullCircleDegrees;
		public const float Rad2Deg = (float)Decimal.Rad2Deg;
		public const float Deg2Rad = (float)Decimal.Deg2Rad;
	}
}