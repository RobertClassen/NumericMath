namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Int
	{
		/// <summary>
		/// The number of <c>byte</c>s.
		/// </summary>
		public const byte Length = sizeof(int);
		/// <summary>
		/// The number of <c>bit</c>s.
		/// </summary>
		public const byte BinaryLength = Length * Byte.BinaryLength;
		public const byte HexLength = BinaryLength >> (One + One);

		public const int Zero = Byte.Zero;
		public const int One = Byte.One;
	}
}