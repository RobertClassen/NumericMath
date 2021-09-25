namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static class ShortExtensions
	{
		#region Constants

		#endregion

		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
		public static short Abs(this short value)
		{
			return Math.Abs(value);
		}

		public static short Clamp(this short value, short min, short max)
		{
			return value <= min ? min : value >= max ? max : value;
		}

		public static short Clamp01(this short value, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled ? value.Clamp(Short.Zero, Short.One) : value;
		}

		public static bool IsClamped(this short value, short min, short max, bool isInclusive = Numeric.IsClampedInclusiveDefault)
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
		public static short Max(this short value, short other)
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
		public static short Min(this short value, short other)
		{
			return Math.Min(value, other);
		}

		public static short Modulo(this short dividend, short divisor)
		{
			if(divisor == Float.Zero)
			{
				throw new DivideByZeroException(nameof(Modulo) + "(0) is undefined.");
			}

			// Puts the dividend in the [-divisor+1, divisor-1] range
			short remainder = (short)(dividend % divisor);

			// If the remainder is less than zero and the divisor is greater than zero, 
			// then adding the divisor puts it in the [0, divisor-1] range.
			// If the divisor is less than zero and the remainder is greater than zero, 
			// then adding the divisor puts it in the [divisor-1, 0] range.
			return (short)(Short.Zero.IsClamped(remainder, divisor, false) || Short.Zero.IsClamped(divisor, remainder, false) ? 
				remainder + divisor : remainder);
		}

		/// <summary>
		/// Returns <c>-1</c>, <c>0</c>, or <c>1</c> to indicate the <c>sign</c> of the <c>value</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.sign
		/// </remarks>
		public static short Sign(this short value)
		{
			return (short)Math.Sign(value);
		}

		public static string ToBinaryString(this short value, int minLength = Short.BitCount)
		{
			return Convert.ToString(value, (int)Numeric.Base.Binary).PadLeft(minLength, Char.Zero);
		}

		public static bool ToBool(this short value)
		{
			return value != Short.Zero;
		}

		public static string ToHexString(this short value, int minLength = Short.HexLength)
		{
			return value.ToString("X" + minLength);
		}

		public static string ToInvariantString(this short value, string format = String.Null)
		{
			return value.ToString(format, Culture.Invariant);
		}
		#endregion
	}
}