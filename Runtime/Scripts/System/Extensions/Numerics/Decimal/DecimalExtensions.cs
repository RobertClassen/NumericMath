namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;
	using Core;

	public static class DecimalExtensions
	{
		public static decimal Abs(this decimal value)
		{
			return Math.Abs(value);
		}

		public static decimal Ceil(this decimal value)
		{
			return Math.Ceiling(value);
		}

		public static long CeilToInt(this decimal value)
		{
			return (long)value.Ceil();
		}

		public static decimal Clamp(this decimal value, decimal min, decimal max)
		{
			return value <= min ? min : value >= max ? max : value;
		}

		public static decimal Clamp01(this decimal value, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled ? value.Clamp(Decimal.Zero, Decimal.One) : value;
		}

		public static decimal Floor(this decimal value)
		{
			return Math.Floor(value);
		}

		public static long FloorToInt(this decimal value)
		{
			return (long)value.Floor();
		}

		public static decimal InverseLerp(this decimal t, decimal a, decimal b, bool IsClamped = Numeric.IsLerpClampedDefault)
		{
			return Decimal.InverseLerp(a, b, t, IsClamped);
		}

		public static bool IsClamped(this decimal value, decimal min, decimal max, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return isInclusive ? min <= value && value <= max : min < value && value < max;
		}

		public static bool IsClamped01(this decimal value, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return value.IsClamped(Decimal.Zero, Decimal.One, isInclusive);
		}

		public static decimal Lerp(this decimal t, decimal a, decimal b, bool IsClamped = Numeric.IsLerpClampedDefault)
		{
			return Decimal.Lerp(a, b, t, IsClamped);
		}

		/// <summary>
		/// Returns the larger of two specified numbers.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.max
		/// </remarks>
		/// <seealso cref="Min"/>
		public static decimal Max(this decimal value, decimal other)
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
		public static decimal Min(this decimal value, decimal other)
		{
			return Math.Min(value, other);
		}

		public static decimal Modulo(this decimal dividend, decimal divisor)
		{
			if(divisor == Decimal.Zero)
			{
				throw new DivideByZeroException(nameof(Modulo) + "(0) is undefined.");
			}

			// Puts the dividend in the [-divisor+1, divisor-1] range
			decimal remainder = dividend % divisor;

			// If the remainder is less than zero and the divisor is greater than zero, 
			// then adding the divisor puts it in the [0, divisor-1] range.
			// If the divisor is less than zero and the remainder is greater than zero, 
			// then adding the divisor puts it in the [divisor-1, 0] range.
			return Decimal.Zero.IsClamped(remainder, divisor, false) || Decimal.Zero.IsClamped(divisor, remainder, false) ? 
				remainder + divisor : remainder;
		}

		public static decimal Remap(this decimal value, decimal fromA, decimal fromB, decimal toA, decimal toB, 
			bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Decimal.Remap(fromA, fromB, toA, toB, value, isClamped);
		}

		public static decimal Round(this decimal value)
		{
			return Math.Round(value);
		}

		public static long RoundToLong(this decimal value)
		{
			return (long)Math.Round(value);
		}

		public static decimal RoundToMid(this decimal value)
		{
			return Math.Round(value) + Decimal.OneHalf;
		}

		/// <summary>
		/// Returns <c>-1M</c>, <c>0M</c>, or <c>1M</c> to indicate the <c>sign</c> of the <c>value</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.sign
		/// </remarks>
		public static decimal Sign(this decimal value)
		{
			return (decimal)Math.Sign(value);
		}

		public static bool ToBool(this decimal value)
		{
			return value != Decimal.Zero;
		}

		public static string ToInvariantString(this decimal value, string format = String.Null)
		{
			return value.ToString(format, Culture.Invariant);
		}

		public static string ToPercentString(this decimal value, CultureInfo cultureInfo = null)
		{
			return (value * Decimal.Hundred).ToString(cultureInfo ?? Culture.Invariant) + String.Percent;
		}
	}
}