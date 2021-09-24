namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Globalization;
	using Core;

	public static class FloatExtensions
	{
		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
		public static float Abs(this float value)
		{
			return Math.Abs(value);
		}

		public static float Ceil(this float value)
		{
			return (float)Math.Ceiling(value);
		}

		public static int CeilToInt(this float value)
		{
			return (int)value.Ceil();
		}

		public static float Clamp(this float value, float min, float max)
		{
			return value <= min ? min : value >= max ? max : value;
		}

		public static float Clamp01(this float value, bool isEnabled = Numeric.IsClampEnabledDefault)
		{
			return isEnabled ? value.Clamp(Float.Zero, Float.One) : value;
		}

		public static float Floor(this float value)
		{
			return (float)Math.Floor(value);
		}

		public static int FloorToInt(this float value)
		{
			return (int)value.Floor();
		}

		public static float InverseLerp(this float t, float a, float b, bool IsClamped = Numeric.IsLerpClampedDefault)
		{
			return Float.InverseLerp(a, b, t, IsClamped);
		}

		public static bool IsClamped(this float value, float min, float max, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return isInclusive ? min <= value && value <= max : min < value && value < max;
		}

		public static bool IsClamped01(this float value, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return value.IsClamped(Float.Zero, Float.One, isInclusive);
		}

		public static float Lerp(this float t, float a, float b, bool IsClamped = Numeric.IsLerpClampedDefault)
		{
			return Float.Lerp(a, b, t, IsClamped);
		}

		/// <remarks>
		/// Repeats the sequence from <c>zero</c> to <c>divisor</c> (exclusively), 
		/// with the direction and <c>sign</c> based on the <c>sign</c> of the <c>divisor</c>.
		/// </remarks>
		/// <seealso cref="Remainder"/>
		/// <example>
		/// <code>
		/// float modulo = 3f;
		/// float[] input    = { -4.9f, -3.9f, -2.9f, -1.9f, -0.9f, 0.1f, 1.1f, 2.1f, 3.1f, 4.1f, 5.1f };
		/// float[] expected = {  1.1f,  2.1f,  0.1f,  1.1f,  2.1f, 0.1f, 1.1f, 2.1f, 0.1f, 1.1f, 2.1f };
		/// float[] actual   = {  1.1f,  2.1f,  0.1f,  1.1f,  2.1f, 0.1f, 1.1f, 2.1f, 0.1f, 1.1f, 2.1f };
		/// </code>
		/// 
		/// <code>
		/// float modulo = -3f;
		/// float[] input    = { -4.9f, -3.9f, -2.9f, -1.9f, -0.9f,  0.1f,  1.1f,  2.1f,  3.1f,  4.1f,  5.1f };
		/// float[] expected = { -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f };
		/// float[] actual   = { -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f };
		/// </code>
		/// </example>
		public static float Modulo(this float dividend, float divisor)
		{
			if(divisor == Float.Zero)
			{
				throw new DivideByZeroException(nameof(Modulo) + "(0) is undefined.");
			}

			// Puts the dividend in the [-divisor+1, divisor-1] range
			float remainder = dividend % divisor;

			// If the remainder is less than zero and the divisor is greater than zero, 
			// then adding the divisor puts it in the [0, divisor-1] range.
			// If the divisor is less than zero and the remainder is greater than zero, 
			// then adding the divisor puts it in the [divisor-1, 0] range.
			return Float.Zero.IsClamped(remainder, divisor, false) || Float.Zero.IsClamped(divisor, remainder, false) ? 
				remainder + divisor : remainder;
		}

		/// <remarks>
		/// Repeats the sequence from <c>zero</c> to <c>divisor</c> (exclusively), 
		/// with the direction and <c>sign</c> based on the <c>sign</c> of the <c>dividend</c>.
		/// </remarks>
		/// <seealso cref="Modulo"/>
		/// <example>
		/// <code>
		/// float modulo = 3f;
		/// float[] input    = { -4.9f, -3.9f, -2.9f, -1.9f, -0.9f, 0.1f, 1.1f, 2.1f, 3.1f, 4.1f, 5.1f };
		/// float[] expected = {  1.1f,  2.1f,  0.1f,  1.1f,  2.1f, 0.1f, 1.1f, 2.1f, 0.1f, 1.1f, 2.1f };
		/// float[] actual   = { -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, 0.1f, 1.1f, 2.1f, 0.1f, 1.1f, 2.1f }; // Wrong for - % +
		/// </code>
		/// 
		/// <code>
		/// float modulo = -3f;
		/// float[] input    = { -4.9f, -3.9f, -2.9f, -1.9f, -0.9f,  0.1f,  1.1f,  2.1f,  3.1f,  4.1f,  5.1f };
		/// float[] expected = { -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f };
		/// float[] actual   = { -1.9f, -0.9f, -2.9f, -1.9f, -0.9f,  0.1f,  1.1f,  2.1f,  0.1f,  1.1f,  2.1f }; // Wrong for + % -
		/// </code>
		/// </example>
		[Obsolete("Use the '%' operator directly instead.")]
		public static float Remainder(this float dividend, float divisor)
		{
			return dividend % divisor;
		}

		public static float Remap(this float value, float fromA, float fromB, float toA, float toB, 
			bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return Float.Remap(fromA, fromB, toA, toB, value, isClamped);
		}

		public static float Round(this float value)
		{
			return (float)Math.Round(value);
		}

		public static int RoundToInt(this float value)
		{
			return (int)Math.Round(value);
		}

		public static float RoundToMid(this float value)
		{
			return value.Round() + Float.OneHalf;
		}

		/// <summary>
		/// Returns <c>-1f</c>, <c>0f</c>, or <c>1f</c> to indicate the <c>sign</c> of the <c>value</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.microsoft.com/dotnet/api/system.math.sign
		/// </remarks>
		public static float Sign(this float value)
		{
			return (float)Math.Sign(value);
		}

		public static bool ToBool(this float value)
		{
			return value != Float.Zero;
		}

		public static string ToInvariantString(this float value, string format = String.Null)
		{
			return value.ToString(format, Culture.Invariant);
		}

		public static string ToPercentString(this float value, CultureInfo cultureInfo = null)
		{
			return (value * Float.Hundred).ToString(cultureInfo ?? Culture.Invariant) + String.Percent;
		}
		#endregion
	}
}