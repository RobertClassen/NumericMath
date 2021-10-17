namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		/// <remarks>
		/// Repeats the sequence from <c>zero</c> to <c>divisor</c> (exclusively), 
		/// with the direction and <c>sign</c> based on the <c>sign</c> of the <c>divisor</c>.
		/// </remarks>
		/// <seealso cref="Remainder"/>
		/// <example>
		/// <code>
		/// decimal modulo = 3M;
		/// decimal[] input    = { -4.9M, -3.9M, -2.9M, -1.9M, -0.9M, 0.1M, 1.1M, 2.1M, 3.1M, 4.1M, 5.1M };
		/// decimal[] expected = {  1.1M,  2.1M,  0.1M,  1.1M,  2.1M, 0.1M, 1.1M, 2.1M, 0.1M, 1.1M, 2.1M };
		/// decimal[] actual   = {  1.1M,  2.1M,  0.1M,  1.1M,  2.1M, 0.1M, 1.1M, 2.1M, 0.1M, 1.1M, 2.1M };
		/// </code>
		/// 
		/// <code>
		/// decimal modulo = -3M;
		/// decimal[] input    = { -4.9M, -3.9M, -2.9M, -1.9M, -0.9M,  0.1M,  1.1M,  2.1M,  3.1M,  4.1M,  5.1M };
		/// decimal[] expected = { -1.9M, -0.9M, -2.9M, -1.9M, -0.9M, -2.9M, -1.9M, -0.9M, -2.9M, -1.9M, -0.9M };
		/// decimal[] actual   = { -1.9M, -0.9M, -2.9M, -1.9M, -0.9M, -2.9M, -1.9M, -0.9M, -2.9M, -1.9M, -0.9M };
		/// </code>
		/// </example>
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
	}
}