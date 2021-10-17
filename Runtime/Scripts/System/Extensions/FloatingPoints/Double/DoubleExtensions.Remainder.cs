namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class DoubleExtensions
	{
		/// <remarks>
		/// Repeats the sequence from <c>zero</c> to <c>divisor</c> (exclusively), 
		/// with the direction and <c>sign</c> based on the <c>sign</c> of the <c>dividend</c>.
		/// </remarks>
		/// <seealso cref="Modulo"/>
		/// <example>
		/// <code>
		/// double modulo = 3d;
		/// double[] input    = { -4.9d, -3.9d, -2.9d, -1.9d, -0.9d, 0.1d, 1.1d, 2.1d, 3.1d, 4.1d, 5.1d };
		/// double[] expected = {  1.1d,  2.1d,  0.1d,  1.1d,  2.1d, 0.1d, 1.1d, 2.1d, 0.1d, 1.1d, 2.1d };
		/// double[] actual   = { -1.9d, -0.9d, -2.9d, -1.9d, -0.9d, 0.1d, 1.1d, 2.1d, 0.1d, 1.1d, 2.1d }; // Wrong for - % +
		/// </code>
		/// 
		/// <code>
		/// double modulo = -3d;
		/// double[] input    = { -4.9d, -3.9d, -2.9d, -1.9d, -0.9d,  0.1d,  1.1d,  2.1d,  3.1d,  4.1d,  5.1d };
		/// double[] expected = { -1.9d, -0.9d, -2.9d, -1.9d, -0.9d, -2.9d, -1.9d, -0.9d, -2.9d, -1.9d, -0.9d };
		/// double[] actual   = { -1.9d, -0.9d, -2.9d, -1.9d, -0.9d,  0.1d,  1.1d,  2.1d,  0.1d,  1.1d,  2.1d }; // Wrong for + % -
		/// </code>
		/// </example>
		[Obsolete("Use the '%' operator directly instead.")]
		public static double Remainder(this double dividend, double divisor)
		{
			if(divisor == Double.Zero)
			{
				throw new DivideByZeroException(nameof(Remainder) + "(0) is undefined.");
			}
			return dividend % divisor;
		}
	}
}