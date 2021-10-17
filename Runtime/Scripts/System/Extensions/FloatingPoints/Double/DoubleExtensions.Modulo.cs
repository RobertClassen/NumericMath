namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		/// <remarks>
		/// Repeats the sequence from <c>zero</c> to <c>divisor</c> (exclusively), 
		/// with the direction and <c>sign</c> based on the <c>sign</c> of the <c>divisor</c>.
		/// </remarks>
		/// <seealso cref="Remainder"/>
		/// <example>
		/// <code>
		/// double modulo = 3d;
		/// double[] input    = { -4.9d, -3.9d, -2.9d, -1.9d, -0.9d, 0.1d, 1.1d, 2.1d, 3.1d, 4.1d, 5.1d };
		/// double[] expected = {  1.1d,  2.1d,  0.1d,  1.1d,  2.1d, 0.1d, 1.1d, 2.1d, 0.1d, 1.1d, 2.1d };
		/// double[] actual   = {  1.1d,  2.1d,  0.1d,  1.1d,  2.1d, 0.1d, 1.1d, 2.1d, 0.1d, 1.1d, 2.1d };
		/// </code>
		/// 
		/// <code>
		/// double modulo = -3d;
		/// double[] input    = { -4.9d, -3.9d, -2.9d, -1.9d, -0.9d,  0.1d,  1.1d,  2.1d,  3.1d,  4.1d,  5.1d };
		/// double[] expected = { -1.9d, -0.9d, -2.9d, -1.9d, -0.9d, -2.9d, -1.9d, -0.9d, -2.9d, -1.9d, -0.9d };
		/// double[] actual   = { -1.9d, -0.9d, -2.9d, -1.9d, -0.9d, -2.9d, -1.9d, -0.9d, -2.9d, -1.9d, -0.9d };
		/// </code>
		/// </example>
		public static double Modulo(this double dividend, double divisor)
		{
			if(divisor == Double.Zero)
			{
				throw new DivideByZeroException(nameof(Modulo) + "(0) is undefined.");
			}

			// Puts the dividend in the [-divisor+1, divisor-1] range
			double remainder = dividend % divisor;

			// If the remainder is less than zero and the divisor is greater than zero, 
			// then adding the divisor puts it in the [0, divisor-1] range.
			// If the divisor is less than zero and the remainder is greater than zero, 
			// then adding the divisor puts it in the [divisor-1, 0] range.
			return Double.Zero.IsClamped(remainder, divisor, false) || Double.Zero.IsClamped(divisor, remainder, false) ? 
				remainder + divisor : remainder;
		}
	}
}