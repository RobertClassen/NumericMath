namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		/// <remarks>
		/// Repeats the sequence from <c>zero</c> to <c>divisor</c> (exclusively), 
		/// with the direction and <c>sign</c> based on the <c>sign</c> of the <c>dividend</c>, component-wise.
		/// </remarks>
		/// <seealso cref="Modulo"/>
		/// <example>
		/// See <see cref ="FloatExtensions.Remainder"/>
		/// </example>
		public static Vector2 Remainder(this Vector2 dividend, Vector2 divisor)
		{
			return new Vector2(dividend.x % divisor.x, dividend.y % divisor.y);
		}
	}
}