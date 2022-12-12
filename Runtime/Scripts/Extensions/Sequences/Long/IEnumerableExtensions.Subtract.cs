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
		public static IEnumerable<long> Subtract(this IEnumerable<long> values, long subtrahend)
		{
			foreach(long value in values)
			{
				yield return value - subtrahend;
			}
		}
	}
}