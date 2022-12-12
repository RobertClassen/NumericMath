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
		public static IEnumerable<short> Divide(this IEnumerable<short> values, short divisor)
		{
			foreach(short value in values)
			{
				yield return (short)(value / divisor);
			}
		}
	}
}