namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IEnumerableExtensions
	{
		/// <summary>
		/// Returns a sequence where the <c>multiplicand</c> is multiplied by each number individually.
		/// </summary>
		public static IEnumerable<byte> Multiply(this IEnumerable<byte> values, byte multiplicand)
		{
			return multiplicand.Multiply(values);
		}
	}
}