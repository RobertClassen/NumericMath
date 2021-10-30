﻿namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class Float
	{
		public const byte BitCount = sizeof(float) * Byte.BitCount;

		public const float Zero = Byte.Zero;
		public const float One = Byte.One;

		public const float OneHalf = One / (One + One);
	}
}