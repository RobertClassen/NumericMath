namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		/// <remarks>
		/// Repeats the sequence from <c>zero</c> to <c>divisor</c> (exclusively), 
		/// with the direction and <c>sign</c> based on the <c>sign</c> of the <c>dividend</c>.
		/// </remarks>
		/// <seealso cref="Modulo"/>
		/// <example>
		/// <code>
		/// long modulo = 3L;
		/// long[] input    = { -4.9L, -3.9L, -2.9L, -1.9L, -0.9L, 0.1L, 1.1L, 2.1L, 3.1L, 4.1L, 5.1L };
		/// long[] expected = {  1.1L,  2.1L,  0.1L,  1.1L,  2.1L, 0.1L, 1.1L, 2.1L, 0.1L, 1.1L, 2.1L };
		/// long[] actual   = { -1.9L, -0.9L, -2.9L, -1.9L, -0.9L, 0.1L, 1.1L, 2.1L, 0.1L, 1.1L, 2.1L }; // Wrong for - % +
		/// </code>
		/// 
		/// <code>
		/// long modulo = -3L;
		/// long[] input    = { -4.9L, -3.9L, -2.9L, -1.9L, -0.9L,  0.1L,  1.1L,  2.1L,  3.1L,  4.1L,  5.1L };
		/// long[] expected = { -1.9L, -0.9L, -2.9L, -1.9L, -0.9L, -2.9L, -1.9L, -0.9L, -2.9L, -1.9L, -0.9L };
		/// long[] actual   = { -1.9L, -0.9L, -2.9L, -1.9L, -0.9L,  0.1L,  1.1L,  2.1L,  0.1L,  1.1L,  2.1L }; // Wrong for + % -
		/// </code>
		/// </example>
		[Obsolete("Use the '%' operator directly instead.")]
		public static long Remainder(this long dividend, long divisor)
		{
			return dividend % divisor;
		}
	}
}