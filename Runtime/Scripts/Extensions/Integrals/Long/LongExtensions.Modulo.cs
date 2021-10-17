namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		/// <remarks>
		/// Repeats the sequence from <c>zero</c> to <c>divisor</c> (exclusively), 
		/// with the direction and <c>sign</c> based on the <c>sign</c> of the <c>divisor</c>.
		/// </remarks>
		/// <seealso cref="Remainder"/>
		/// <example>
		/// <code>
		/// long modulo = 3L;
		/// long[] input    = { -4.9L, -3.9L, -2.9L, -1.9L, -0.9L, 0.1L, 1.1L, 2.1L, 3.1L, 4.1L, 5.1L };
		/// long[] expected = {  1.1L,  2.1L,  0.1L,  1.1L,  2.1L, 0.1L, 1.1L, 2.1L, 0.1L, 1.1L, 2.1L };
		/// long[] actual   = {  1.1L,  2.1L,  0.1L,  1.1L,  2.1L, 0.1L, 1.1L, 2.1L, 0.1L, 1.1L, 2.1L };
		/// </code>
		/// 
		/// <code>
		/// long modulo = -3L;
		/// long[] input    = { -4.9L, -3.9L, -2.9L, -1.9L, -0.9L,  0.1L,  1.1L,  2.1L,  3.1L,  4.1L,  5.1L };
		/// long[] expected = { -1.9L, -0.9L, -2.9L, -1.9L, -0.9L, -2.9L, -1.9L, -0.9L, -2.9L, -1.9L, -0.9L };
		/// long[] actual   = { -1.9L, -0.9L, -2.9L, -1.9L, -0.9L, -2.9L, -1.9L, -0.9L, -2.9L, -1.9L, -0.9L };
		/// </code>
		/// </example>
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
	}
}