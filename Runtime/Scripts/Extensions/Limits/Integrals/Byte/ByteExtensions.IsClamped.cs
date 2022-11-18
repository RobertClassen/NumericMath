namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ByteExtensions
	{
		public static bool IsClamped(this byte value, byte min, byte max, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return isInclusive ? min <= value && value <= max : min < value && value < max;
		}

		public static bool IsClamped01(this byte value, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return value.IsClamped(Byte.Zero, Byte.One, isInclusive);
		}
	}
}