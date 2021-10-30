namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		/// <remarks>
		/// Repeats the sequence from <c>zero</c> to <c>divisor</c> (exclusively), 
		/// with the direction and <c>sign</c> based on the <c>sign</c> of the <c>dividend</c>.
		/// </remarks>
		/// <seealso cref="Modulo"/>
		/// <example>
		/// <code>
		/// float modulo = 3f;
		/// float[] input    = { -4.9f, -3.9f, -2.9f, -1.9f, -0.9f, 0.1f, 1.1f, 2.1f, 3.1f, 4.1f, 5.1f };
		/// float[] expected = {  1.1f,  2.1f,  0.1f,  1.1f,  2.1f, 0.1f, 1.1f, 2.1f, 0.1f, 1.1f, 2.1f };
		/// float[] actual   = { -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, 0.1f, 1.1f, 2.1f, 0.1f, 1.1f, 2.1f }; // Wrong for - % +
		/// </code>
		/// 
		/// <code>
		/// float modulo = -3f;
		/// float[] input    = { -4.9f, -3.9f, -2.9f, -1.9f, -0.9f,  0.1f,  1.1f,  2.1f,  3.1f,  4.1f,  5.1f };
		/// float[] expected = { -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f };
		/// float[] actual   = { -1.9f, -0.9f, -2.9f, -1.9f, -0.9f,  0.1f,  1.1f,  2.1f,  0.1f,  1.1f,  2.1f }; // Wrong for + % -
		/// </code>
		/// </example>
		[Obsolete("Use the '%' operator directly instead.")]
		public static float Remainder(this float dividend, float divisor)
		{
			if(divisor == Float.Zero)
			{
				throw new DivideByZeroException(nameof(Remainder) + "(0) is undefined.");
			}
			return dividend % divisor;
		}
	}
}