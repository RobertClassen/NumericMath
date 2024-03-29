﻿namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Double
	{
		public const byte BinaryLength = sizeof(double) * Byte.BinaryLength;

		public const double Zero = Byte.Zero;
		public const double One = Byte.One;

		public const double OneHalf = One / (One + One);

		public const double FullCircleDegrees = 360d;
		public const double HalfCircleDegrees = FullCircleDegrees * OneHalf;
		public const double Rad2Deg = HalfCircleDegrees / Math.PI;
		public const double Deg2Rad = One / Rad2Deg;
	}
}