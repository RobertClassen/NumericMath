namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IListExtensions
	{
		/// <summary>
		/// Returns a sequence where the <c>multiplicand</c> is multiplied by each number individually.
		/// </summary>
		public static IEnumerable<long> Multiply(this IList<long> values, long multiplicand)
		{
			return multiplicand.Multiply(values);
		}
	}
}