namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static class ByteExtensions
	{
		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
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

		/// <summary>
		/// Returns the larger of two specified numbers.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.max
		/// </remarks>
		/// <seealso cref="Min"/>
		public static byte Max(this byte value, byte other)
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
		public static byte Min(this byte value, byte other)
		{
			return Math.Min(value, other);
		}

		public static byte Modulo(this byte dividend, byte divisor)
		{
			if(divisor == Int.Zero)
			{
				throw new DivideByZeroException(nameof(Modulo) + "(0) is undefined.");
			}

			// Puts the dividend in the [-divisor+1, divisor-1] range
			byte remainder = (byte)(dividend % divisor);

			// If the remainder is less than zero and the divisor is greater than zero, 
			// then adding the divisor puts it in the [0, divisor-1] range.
			// If the divisor is less than zero and the remainder is greater than zero, 
			// then adding the divisor puts it in the [divisor-1, 0] range.
			return (byte)(Byte.Zero.IsClamped(remainder, divisor, false) || Byte.Zero.IsClamped(divisor, remainder, false) ? 
				remainder + divisor : remainder);
		}

		/// <summary>
		/// Returns <c>-1</c>, <c>0</c>, or <c>1</c> to indicate the <c>sign</c> of the <c>value</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.sign
		/// </remarks>
		public static byte Sign(this byte value)
		{
			return (byte)Math.Sign((short)value);
		}

		public static string ToBinaryString(this byte value, int minLength = Byte.BitCount)
		{
			return Convert.ToString(value, (int)Numeric.Base.Binary).PadLeft(minLength, Char.Zero);
		}

		public static bool ToBool(this byte value)
		{
			return value != Byte.Zero;
		}

		public static string ToHexString(this byte value, int minLength = Byte.HexLength)
		{
			return value.ToString("X" + minLength);
		}

		public static string ToInvariantString(this byte value, string format = String.Null)
		{
			return value.ToString(format, Culture.Invariant);
		}
		#endregion
	}
}