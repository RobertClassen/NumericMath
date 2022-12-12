namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IEnumerableExtensions
	{
		/// <summary>
		/// Returns a sequence where each number is divided by the <c>divisor</c> individually.
		/// </summary>
		public static IEnumerable<long> Divide(this IEnumerable<long> values, long divisor)
		{
			foreach(long value in values)
			{
				yield return value / divisor;
			}
		}
	}
}