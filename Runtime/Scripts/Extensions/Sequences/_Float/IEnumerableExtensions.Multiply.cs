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
		public static IEnumerable<float> Multiply(this IEnumerable<float> values, float multiplicand)
		{
			return multiplicand.Multiply(values);
		}
	}
}