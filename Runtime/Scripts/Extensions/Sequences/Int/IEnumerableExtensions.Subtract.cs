namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IEnumerableExtensions
	{
		/// <summary>
		/// Returns a sequence where the <c>subtrahend</c> is subtracted from each number individually.
		/// </summary>
		public static IEnumerable<int> Subtract(this IEnumerable<int> values, int subtrahend)
		{
			foreach(int value in values)
			{
				yield return value - subtrahend;
			}
		}
	}
}