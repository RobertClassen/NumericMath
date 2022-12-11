namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IEnumerableExtensions
	{
		/// <summary>
		/// Returns a sequence where the <c>addend</c> is added to each number individually.
		/// </summary>
		public static IEnumerable<long> Add(this IEnumerable<long> values, long addend)
		{
			return addend.Add(values);
		}
	}
}