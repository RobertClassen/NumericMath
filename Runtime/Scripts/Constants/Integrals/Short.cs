namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Short
	{
		/// <summary>
		/// The number of <c>byte</c>s.
		/// </summary>
		public const byte Length = sizeof(short);
		/// <summary>
		/// The number of <c>bit</c>s.
		/// </summary>
		public const byte BinaryLength = Length * Byte.BinaryLength;
		public const byte HexLength = BinaryLength >> (One + One);

		public const short Zero = Byte.Zero;
		public const short One = Byte.One;
	}
}