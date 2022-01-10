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

		public const float OneHalf = (float)Double.OneHalf;

		public const float FullCircleDegrees = (float)Double.FullCircleDegrees;
		public const float HalfCircleDegrees = (float)Double.HalfCircleDegrees;
		public const float Rad2Deg = (float)Double.Rad2Deg;
		public const float Deg2Rad = (float)Double.Deg2Rad;
	}
}