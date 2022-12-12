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
		public static IEnumerable<int> Divide(this IEnumerable<int> values, int divisor)
		{
			foreach(int value in values)
			{
				yield return value / divisor;
			}
		}
	}
}