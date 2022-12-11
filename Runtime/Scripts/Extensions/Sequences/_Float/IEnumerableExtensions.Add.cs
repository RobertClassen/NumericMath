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
		public static IEnumerable<float> Add(this IEnumerable<float> values, float addend)
		{
			return addend.Add(values);
		}
	}
}