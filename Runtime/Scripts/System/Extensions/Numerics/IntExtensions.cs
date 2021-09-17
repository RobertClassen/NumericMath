namespace WellDefined
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static class IntExtensions
	{
		#region Fields
		
		#endregion

		#region Properties
		
		#endregion

		#region Constructors
		
		#endregion

		#region Methods
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

		public static int Clamp01(this int value, bool isClamped = Numeric.IsClampClampedDefault)
		{
			return isClamped ? value.Clamp(Int.Zero, Int.One) : value;
		}

		public static bool IsClamped(this int value, int min, int max, bool isInclusive = Numeric.IsClampedInclusiveDefault)
		{
			return isInclusive ? min <= value && value <= max : min < value && value < max;
		}

		public static bool IsClamped<T>(this int value, ICollection<T> iCollection)
		{
			return value.IsClamped(Int.Zero, iCollection.Count - Int.One);
		}

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

		public static int Sign(this int value)
		{
			return Math.Sign(value);
		}

		public static string ToBinaryString(this int value)
		{
			return Convert.ToString(value, Numeric.BinaryBase);
		}

		public static bool ToBool(this int value)
		{
			return value != Int.Zero;
		}

		public static string ToInvariantString(this int value, string format = String.Null)
		{
			return value.ToString(format, Culture.Invariant);
		}
		#endregion
	}
}