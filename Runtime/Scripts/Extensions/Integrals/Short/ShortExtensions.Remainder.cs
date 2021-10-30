namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		/// <remarks>
		/// Repeats the sequence from <c>zero</c> to <c>divisor</c> (exclusively), 
		/// with the direction and <c>sign</c> based on the <c>sign</c> of the <c>dividend</c>.
		/// </remarks>
		/// <seealso cref="Modulo"/>
		/// <example>
		/// <code>
		/// short modulo = 3;
		/// short[] input    = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
		/// short[] expected = {  1,  2,  0,  1,  2, 0, 1, 2, 0, 1, 2 };
		/// short[] actual   = { -2, -1,  0, -2, -1, 0, 1, 2, 0, 1, 2 }; // Wrong for - % +
		/// </code>
		/// 
		/// <code>
		/// short modulo = -3;
		/// short[] input    = { -5, -4, -3, -2, -1, 0,  1,  2, 3,  4,  5 };
		/// short[] expected = { -2, -1,  0, -2, -1, 0, -2, -1, 0, -2, -1 };
		/// short[] actual   = { -2, -1,  0, -2, -1, 0,  1,  2, 0,  1,  2 }; // Wrong for + % -
		/// </code>
		/// </example>
		[Obsolete("Use the '%' operator directly instead.")]
		public static short Remainder(this short dividend, short divisor)
		{
			if(divisor == Short.Zero)
			{
				throw new DivideByZeroException(nameof(Remainder) + "(0) is undefined.");
			}
			return (short)(dividend % divisor);
		}
	}
}