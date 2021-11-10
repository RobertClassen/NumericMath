namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
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
		public static byte Remainder(this byte dividend, byte divisor)
		{
			if(divisor == Byte.Zero)
			{
				throw new DivideByZeroException(nameof(Remainder) + "(0) is undefined.");
			}
			return (byte)(dividend % divisor);
		}
	}
}