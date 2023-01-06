namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ByteExtensions
	{
		public static bool IsClamped01(this byte value, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return value.IsClamped(Byte.Zero, Byte.One, isInclusive);
		}
	}
}