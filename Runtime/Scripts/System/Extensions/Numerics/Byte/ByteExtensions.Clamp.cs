namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ByteExtensions
	{
		public static byte Clamp(this byte value, byte min, byte max)
		{
			return value <= min ? min : value >= max ? max : value;
		}

		public static byte Clamp01(this byte value, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled ? value.Clamp(Byte.Zero, Byte.One) : value;
		}

		public static bool IsClamped(this byte value, byte min, byte max, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return isInclusive ? min <= value && value <= max : min < value && value < max;
		}
	}
}