namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Double
	{
		public const byte BitCount = sizeof(double) * Byte.BitCount;

		public const double Zero = Byte.Zero;
		public const double One = Byte.One;
		public const double Hundred = Byte.Hundred;

		public const double OneHalf = One / (One + One);
	}
}