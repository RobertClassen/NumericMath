namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Double
	{
		public const byte BinaryLength = sizeof(double) * Byte.BinaryLength;

		public const double Zero = Byte.Zero;
		public const double One = Byte.One;

		public const double OneHalf = (double)Decimal.OneHalf;

		public const double FullCircleDegrees = (double)Decimal.FullCircleDegrees;
		public const double HalfCircleDegrees = (double)Decimal.HalfCircleDegrees;
		public const double Rad2Deg = (double)Decimal.Rad2Deg;
		public const double Deg2Rad = (double)Decimal.Deg2Rad;
	}
}