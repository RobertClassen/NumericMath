namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		/// <remarks>
		/// Repeats the sequence from <c>zero</c> to <c>divisor</c> (exclusively), 
		/// with the direction and <c>sign</c> based on the <c>sign</c> of the <c>divisor</c>.
		/// </remarks>
		/// <seealso cref="Remainder"/>
		/// <example>
		/// <code>
		/// float modulo = 3f;
		/// float[] input    = { -4.9f, -3.9f, -2.9f, -1.9f, -0.9f, 0.1f, 1.1f, 2.1f, 3.1f, 4.1f, 5.1f };
		/// float[] expected = {  1.1f,  2.1f,  0.1f,  1.1f,  2.1f, 0.1f, 1.1f, 2.1f, 0.1f, 1.1f, 2.1f };
		/// float[] actual   = {  1.1f,  2.1f,  0.1f,  1.1f,  2.1f, 0.1f, 1.1f, 2.1f, 0.1f, 1.1f, 2.1f };
		/// </code>
		/// 
		/// <code>
		/// float modulo = -3f;
		/// float[] input    = { -4.9f, -3.9f, -2.9f, -1.9f, -0.9f,  0.1f,  1.1f,  2.1f,  3.1f,  4.1f,  5.1f };
		/// float[] expected = { -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f };
		/// float[] actual   = { -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f, -2.9f, -1.9f, -0.9f };
		/// </code>
		/// </example>
		public static float Modulo(this float dividend, float divisor, float offset = Float.Zero)
		{
			if(divisor == Float.Zero)
			{
				throw new DivideByZeroException(nameof(Modulo) + "(0) is undefined.");
			}

			// Puts the dividend in the [-divisor+1, divisor-1] range
			float remainder = (dividend - offset) % divisor;

			// If the remainder is less than zero and the divisor is greater than zero, 
			// then adding the divisor puts it in the [0, divisor-1] range.
			// If the divisor is less than zero and the remainder is greater than zero, 
			// then adding the divisor puts it in the [divisor-1, 0] range.
			return Float.Zero.IsClamped(remainder, divisor, false)
			|| Float.Zero.IsClamped(divisor, remainder, false) 
				? remainder + offset + divisor 
				: remainder + offset;
		}
	}
}