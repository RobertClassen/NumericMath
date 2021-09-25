namespace WellDefinedValues
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

		public static long Clamp01(this long value, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled ? value.Clamp(Long.Zero, Long.One) : value;
		}

		public static bool IsClamped(this long value, long min, long max, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return isInclusive ? min <= value && value <= max : min < value && value < max;
		}

		/// <summary>
		/// Returns the larger of two specified numbers.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.max
		/// </remarks>
		/// <seealso cref="Min"/>
		public static long Max(this long value, long other)
		{
			return Math.Max(value, other);
		}

		/// <summary>
		/// Returns the smaller of two specified numbers.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.min
		/// </remarks>
		/// <seealso cref="Max"/>
		public static long Min(this long value, long other)
		{
			return Math.Min(value, other);
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

		/// <summary>
		/// Returns <c>-1L</c>, <c>0L</c>, or <c>1L</c> to indicate the <c>sign</c> of the <c>value</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.sign
		/// </remarks>
		public static long Sign(this long value)
		{
			return (long)Math.Sign(value);
		}

		public static string ToBinaryString(this long value)
		{
			return Convert.ToString(value, (int)Numeric.Base.Binary);
		}

		public static bool ToBool(this long value)
		{
			return value != Long.Zero;
		}

		public static string ToHexString(this long value)
		{
			return value.ToString("X16");
		}

		public static string ToInvariantString(this long value, string format = String.Null)
		{
			return value.ToString(format, Culture.Invariant);
		}
		#endregion
	}
}