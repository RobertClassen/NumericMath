namespace WellDefined
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static class LongExtensions
	{
		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
		public static long Abs(this long value)
		{
			return Math.Abs(value);
		}

		public static long Clamp(this long value, long min, long max)
		{
			return value <= min ? min : value >= max ? max : value;
		}

		public static long Clamp01(this long value, bool isClamped = Numeric.IsClampClampedDefault)
		{
			return isClamped ? value.Clamp(Long.Zero, Long.One) : value;
		}

		public static bool IsClamped(this long value, long min, long max, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return isInclusive ? min <= value && value <= max : min < value && value < max;
		}

		public static long Modulo(this long dividend, long divisor)
		{
			if(divisor == Long.Zero)
			{
				throw new DivideByZeroException(nameof(Modulo) + "(0) is undefined.");
			}

			// Puts the dividend in the [-divisor+1, divisor-1] range
			long remainder = dividend % divisor;

			// If the remainder is less than zero and the divisor is greater than zero, 
			// then adding the divisor puts it in the [0, divisor-1] range.
			// If the divisor is less than zero and the remainder is greater than zero, 
			// then adding the divisor puts it in the [divisor-1, 0] range.
			return Long.Zero.IsClamped(remainder, divisor, false) || Long.Zero.IsClamped(divisor, remainder, false) ? 
				remainder + divisor : remainder;
		}

		public static int Sign(this long value)
		{
			return Math.Sign(value);
		}

		public static string ToBinaryString(this long value)
		{
			return Convert.ToString(value, Numeric.BinaryBase);
		}

		public static bool ToBool(this long value)
		{
			return value != Long.Zero;
		}

		public static string ToInvariantString(this long value, string format = String.Null)
		{
			return value.ToString(format, Culture.Invariant);
		}
		#endregion
	}
}