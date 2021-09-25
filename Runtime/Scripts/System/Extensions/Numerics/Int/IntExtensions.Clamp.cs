namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class IntExtensions
	{
		public static int Clamp(this int value, int min, int max)
		{
			return value <= min ? min : value >= max ? max : value;
		}

		public static int Clamp<T>(this int value, ICollection<T> iCollection)
		{
			return value.Clamp(Int.Zero, iCollection.Count - Int.One);
		}

		public static int Clamp01(this int value, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled ? value.Clamp(Int.Zero, Int.One) : value;
		}

		public static bool IsClamped(this int value, int min, int max, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return isInclusive ? min <= value && value <= max : min < value && value < max;
		}

		public static bool IsClamped<T>(this int value, ICollection<T> iCollection)
		{
			return value.IsClamped(Int.Zero, iCollection.Count - Int.One);
		}
	}
}