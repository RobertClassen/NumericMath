namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Long
	{
		/// <summary>
		/// The number of <c>byte</c>s.
		/// </summary>
		public const byte Length = sizeof(long);
		/// <summary>
		/// The number of <c>bit</c>s.
		/// </summary>
		public const byte BinaryLength = Length * Byte.BinaryLength;
		public const byte HexLength = BinaryLength >> (int)(One + One);

		public const long Zero = Byte.Zero;
		public const long One = Byte.One;
	}
}