namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Byte
	{
		/// <summary>
		/// The number of <c>byte</c>s.
		/// </summary>
		public const byte Length = sizeof(byte);
		/// <summary>
		/// The number of <c>bit</c>s.
		/// </summary>
		public const byte BinaryLength = Length * 8;
		public const byte HexLength = BinaryLength >> (One + One);

		public const byte Zero = One - One;
		public const byte One = 1;
	}
}