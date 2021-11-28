namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class IntExtensions
	{
		public static bool IsClamped(this int value, int min, int max, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return isInclusive ? min <= value && value <= max : min < value && value < max;
		}

		public static bool IsClamped<T>(this int value, ICollection<T> iCollection)
		{
			return value.IsClamped(Int.Zero, iCollection.Count - Int.One);
		}

		public static bool IsClamped01(this int value, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return value.IsClamped(Int.Zero, Int.One, isInclusive);
		}

		public static bool IsEven(this int value)
		{
			return value % (int)Numeric.Base.Binary == Int.Zero;
		}

		public static bool IsOdd(this int value)
		{
			return value % (int)Numeric.Base.Binary != Int.Zero;
		}
	}
}