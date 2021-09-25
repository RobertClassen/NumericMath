namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
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
		public static byte Modulo(this byte dividend, byte divisor)
		{
			if(divisor == Byte.Zero)
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
	}
}