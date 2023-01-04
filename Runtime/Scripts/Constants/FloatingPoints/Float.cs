namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Float
	{
		/// <summary>
		/// The number of <c>byte</c>s.
		/// </summary>
		public const byte Length = sizeof(float);
		/// <summary>
		/// The number of <c>bit</c>s.
		/// </summary>
		public const byte BinaryLength = Length * Byte.BinaryLength;

		public const float Zero = Byte.Zero;
		public const float One = Byte.One;

		public const float OneHalf = (float)Double.OneHalf;

		public const float FullCircleDegrees = (float)Double.FullCircleDegrees;
		public const float HalfCircleDegrees = (float)Double.HalfCircleDegrees;
		public const float Rad2Deg = (float)Double.Rad2Deg;
		public const float Deg2Rad = (float)Double.Deg2Rad;

		public const float Epsilon = (float)1E-7;
	}
}