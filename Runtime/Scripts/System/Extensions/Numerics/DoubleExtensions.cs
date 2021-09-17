namespace WellDefined
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;
	using Core;

	public static class DoubleExtensions
	{
		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
		public static double Abs(this double value)
		{
			return Math.Abs(value);
		}

		public static double Ceil(this double value)
		{
			return Math.Ceiling(value);
		}

		public static long CeilToInt(this double value)
		{
			return (long)value.Ceil();
		}

		public static double Clamp(this double value, double min, double max)
		{
			return value <= min ? min : value >= max ? max : value;
		}

		public static double Clamp01(this double value, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled ? value.Clamp(Double.Zero, Double.One) : value;
		}

		public static double Floor(this double value)
		{
			return Math.Floor(value);
		}

		public static long FloorToInt(this double value)
		{
			return (long)value.Floor();
		}

		public static double InverseLerp(this double t, double a, double b, bool IsClamped = Numeric.IsLerpClampedDefault)
		{
			return Double.InverseLerp(a, b, t, IsClamped);
		}

		public static bool IsClamped(this double value, double min, double max, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return isInclusive ? min <= value && value <= max : min < value && value < max;
		}

		public static bool IsClamped01(this double value, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return value.IsClamped(Double.Zero, Double.One, isInclusive);
		}

		public static double Lerp(this double t, double a, double b, bool IsClamped = Numeric.IsLerpClampedDefault)
		{
			return Double.Lerp(a, b, t, IsClamped);
		}

		public static double Modulo(this double dividend, double divisor)
		{
			if(divisor == Double.Zero)
			{
				throw new DivideByZeroException(nameof(Modulo) + "(0) is undefined.");
			}

			// Puts the dividend in the [-divisor+1, divisor-1] range
			double remainder = dividend % divisor;

			// If the remainder is less than zero and the divisor is greater than zero, 
			// then adding the divisor puts it in the [0, divisor-1] range.
			// If the divisor is less than zero and the remainder is greater than zero, 
			// then adding the divisor puts it in the [divisor-1, 0] range.
			return Double.Zero.IsClamped(remainder, divisor, false) || Double.Zero.IsClamped(divisor, remainder, false) ? 
				remainder + divisor : remainder;
		}

		public static double Remap(this double value, double fromA, double fromB, double toA, double toB, 
			bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Double.Remap(fromA, fromB, toA, toB, value, isClamped);
		}

		public static double Round(this double value)
		{
			return Math.Round(value);
		}

		public static long RoundToLong(this double value)
		{
			return (long)Math.Round(value);
		}

		public static double RoundToMid(this double value)
		{
			return Math.Round(value) + Double.OneHalf;
		}

		public static int Sign(this double value)
		{
			return Math.Sign(value);
		}

		public static bool ToBool(this double value)
		{
			return value != Double.Zero;
		}

		public static string ToInvariantString(this double value, string format = String.Null)
		{
			return value.ToString(format, Culture.Invariant);
		}

		public static string ToPercentString(this double value, CultureInfo cultureInfo = null)
		{
			return (value * Double.Hundred).ToString(cultureInfo ?? Culture.Invariant) + String.Percent;
		}
		#endregion
	}
}