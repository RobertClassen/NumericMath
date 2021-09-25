namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static class IntExtensions
	{
		public static int Abs(this int value)
		{
			return Math.Abs(value);
		}

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

		/// <summary>
		/// Returns the larger of two specified numbers.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.max
		/// </remarks>
		/// <seealso cref="Min"/>
		public static int Max(this int value, int other)
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
		public static int Min(this int value, int other)
		{
			return Math.Min(value, other);
		}

		/// <remarks>
		/// Repeats the sequence from <c>zero</c> to <c>divisor</c> (exclusively), 
		/// with the direction and <c>sign</c> based on the <c>sign</c> of the <c>divisor</c>.
		/// </remarks>
		/// <seealso cref="Remainder"/>
		/// <example>
		/// <code>
		/// int modulo = 3;
		/// int[] input    = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
		/// int[] expected = {  1,  2,  0,  1,  2, 0, 1, 2, 0, 1, 2 };
		/// int[] actual   = {  1,  2,  0,  1,  2, 0, 1, 2, 0, 1, 2 };
		/// </code>
		/// 
		/// <code>
		/// int modulo = -3;
		/// int[] input    = { -5, -4, -3, -2, -1, 0,  1,  2, 3,  4,  5 };
		/// int[] expected = { -2, -1,  0, -2, -1, 0, -2, -1, 0, -2, -1 };
		/// int[] actual   = { -2, -1,  0, -2, -1, 0, -2, -1, 0, -2, -1 };
		/// </code>
		/// </example>
		public static int Modulo(this int dividend, int divisor)
		{
			if(divisor == Int.Zero)
			{
				throw new DivideByZeroException(nameof(Modulo) + "(0) is undefined.");
			}

			// Puts the dividend in the [-divisor+1, divisor-1] range
			int remainder = dividend % divisor;

			// If the remainder is less than zero and the divisor is greater than zero, 
			// then adding the divisor puts it in the [0, divisor-1] range.
			// If the divisor is less than zero and the remainder is greater than zero, 
			// then adding the divisor puts it in the [divisor-1, 0] range.
			return Int.Zero.IsClamped(remainder, divisor, false) || Int.Zero.IsClamped(divisor, remainder, false) ? 
				remainder + divisor : remainder;
		}

		/// <remarks>
		/// Repeats the sequence from <c>zero</c> to <c>divisor</c> (exclusively), 
		/// with the direction and <c>sign</c> based on the <c>sign</c> of the <c>dividend</c>.
		/// </remarks>
		/// <seealso cref="Modulo"/>
		/// <example>
		/// <code>
		/// int modulo = 3;
		/// int[] input    = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
		/// int[] expected = {  1,  2,  0,  1,  2, 0, 1, 2, 0, 1, 2 };
		/// int[] actual   = { -2, -1,  0, -2, -1, 0, 1, 2, 0, 1, 2 }; // Wrong for - % +
		/// </code>
		/// 
		/// <code>
		/// int modulo = -3;
		/// int[] input    = { -5, -4, -3, -2, -1, 0,  1,  2, 3,  4,  5 };
		/// int[] expected = { -2, -1,  0, -2, -1, 0, -2, -1, 0, -2, -1 };
		/// int[] actual   = { -2, -1,  0, -2, -1, 0,  1,  2, 0,  1,  2 }; // Wrong for + % -
		/// </code>
		/// </example>
		[Obsolete("Use the '%' operator directly instead.")]
		public static int Remainder(this int dividend, int divisor)
		{
			if(divisor == Int.Zero)
			{
				throw new DivideByZeroException(nameof(Remainder) + "(0) is undefined.");
			}
			return dividend % divisor;
		}

		/// <summary>
		/// Returns <c>-1</c>, <c>0</c>, or <c>1</c> to indicate the <c>sign</c> of the <c>value</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.sign
		/// </remarks>
		public static int Sign(this int value)
		{
			return Math.Sign(value);
		}

		public static string ToBinaryString(this int value, int minLength = Int.BitCount)
		{
			return Convert.ToString(value, (int)Numeric.Base.Binary).PadLeft(minLength, Char.Zero);
		}

		public static bool ToBool(this int value)
		{
			return value != Int.Zero;
		}

		public static string ToHexString(this int value, int minLength = Int.HexLength)
		{
			return value.ToString("X" + minLength);
		}

		public static string ToInvariantString(this int value, string format = String.Null)
		{
			return value.ToString(format, Culture.Invariant);
		}
	}
}