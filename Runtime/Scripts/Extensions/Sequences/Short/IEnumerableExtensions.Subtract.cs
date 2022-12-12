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
		public static IEnumerable<short> Subtract(this IEnumerable<short> values, short subtrahend)
		{
			foreach(short value in values)
			{
				yield return (short)(value - subtrahend);
			}
		}
	}
}