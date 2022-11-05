namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Double
	{
		/// <summary>
		/// The number of <c>byte</c>s.
		/// </summary>
		public const byte Length = sizeof(double);
		/// <summary>
		/// The number of <c>bit</c>s.
		/// </summary>
		public const byte BinaryLength = Length * Byte.BinaryLength;

		public const double Zero = Byte.Zero;
		public const double One = Byte.One;

		public const double OneHalf = One / (One + One);

		public const double FullCircleDegrees = 360d;
		public const double HalfCircleDegrees = FullCircleDegrees * OneHalf;
		public const double Rad2Deg = HalfCircleDegrees / Math.PI;
		public const double Deg2Rad = One / Rad2Deg;
	}
}