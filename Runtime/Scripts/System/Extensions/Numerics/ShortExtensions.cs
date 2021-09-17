namespace WellDefined
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

		public static short Clamp01(this short value, bool isClamped = Numeric.IsClampClampedDefault)
		{
			return isClamped ? value.Clamp(Short.Zero, Short.One) : value;
		}

		public static bool IsClamped(this short value, short min, short max, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return isInclusive ? min <= value && value <= max : min < value && value < max;
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

		public static int Sign(this short value)
		{
			return Math.Sign(value);
		}

		public static string ToBinaryString(this short value)
		{
			return Convert.ToString(value, Numeric.BinaryBase);
		}

		public static bool ToBool(this short value)
		{
			return value != Short.Zero;
		}

		public static string ToInvariantString(this short value, string format = String.Null)
		{
			return value.ToString(format, Culture.Invariant);
		}
		#endregion
	}
}