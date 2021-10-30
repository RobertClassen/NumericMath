namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DecimalExtensions
	{
		/// <remarks>
		/// Repeats the sequence from <c>zero</c> to <c>divisor</c> (exclusively), 
		/// with the direction and <c>sign</c> based on the <c>sign</c> of the <c>dividend</c>.
		/// </remarks>
		/// <seealso cref="Modulo"/>
		/// <example>
		/// <code>
		/// decimal modulo = 3M;
		/// decimal[] input    = { -4.9M, -3.9M, -2.9M, -1.9M, -0.9M, 0.1M, 1.1M, 2.1M, 3.1M, 4.1M, 5.1M };
		/// decimal[] expected = {  1.1M,  2.1M,  0.1M,  1.1M,  2.1M, 0.1M, 1.1M, 2.1M, 0.1M, 1.1M, 2.1M };
		/// decimal[] actual   = { -1.9M, -0.9M, -2.9M, -1.9M, -0.9M, 0.1M, 1.1M, 2.1M, 0.1M, 1.1M, 2.1M }; // Wrong for - % +
		/// </code>
		/// 
		/// <code>
		/// decimal modulo = -3M;
		/// decimal[] input    = { -4.9M, -3.9M, -2.9M, -1.9M, -0.9M,  0.1M,  1.1M,  2.1M,  3.1M,  4.1M,  5.1; };
		/// decimal[] expected = { -1.9M, -0.9M, -2.9M, -1.9M, -0.9M, -2.9M, -1.9M, -0.9M, -2.9M, -1.9M, -0.9; };
		/// decimal[] actual   = { -1.9M, -0.9M, -2.9M, -1.9M, -0.9M,  0.1M,  1.1M,  2.1M,  0.1M,  1.1M,  2.1; }; // Wrong for + % -
		/// </code>
		/// </example>
		[Obsolete("Use the '%' operator directly instead.")]
		public static decimal Remainder(this decimal dividend, decimal divisor)
		{
			if(divisor == Decimal.Zero)
			{
				throw new DivideByZeroException(nameof(Remainder) + "(0) is undefined.");
			}
			return dividend % divisor;
		}
	}
}