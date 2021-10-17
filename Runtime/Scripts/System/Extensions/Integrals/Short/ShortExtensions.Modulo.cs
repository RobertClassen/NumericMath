namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		/// <remarks>
		/// Repeats the sequence from <c>zero</c> to <c>divisor</c> (exclusively), 
		/// with the direction and <c>sign</c> based on the <c>sign</c> of the <c>divisor</c>.
		/// </remarks>
		/// <seealso cref="Remainder"/>
		/// <example>
		/// <code>
		/// short modulo = 3;
		/// short[] input    = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
		/// short[] expected = {  1,  2,  0,  1,  2, 0, 1, 2, 0, 1, 2 };
		/// short[] actual   = {  1,  2,  0,  1,  2, 0, 1, 2, 0, 1, 2 };
		/// </code>
		/// 
		/// <code>
		/// short modulo = -3;
		/// short[] input    = { -5, -4, -3, -2, -1, 0,  1,  2, 3,  4,  5 };
		/// short[] expected = { -2, -1,  0, -2, -1, 0, -2, -1, 0, -2, -1 };
		/// short[] actual   = { -2, -1,  0, -2, -1, 0, -2, -1, 0, -2, -1 };
		/// </code>
		/// </example>
		public static short Modulo(this short dividend, short divisor)
		{
			if(divisor == Short.Zero)
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
	}
}