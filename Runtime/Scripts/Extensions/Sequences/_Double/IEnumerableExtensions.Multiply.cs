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
		public static IEnumerable<double> Multiply(this IEnumerable<double> values, double multiplicand)
		{
			return multiplicand.Multiply(values);
		}
	}
}