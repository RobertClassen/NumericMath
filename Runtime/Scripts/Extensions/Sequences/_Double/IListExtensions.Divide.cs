namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IListExtensions
	{
		/// <summary>
		/// Returns a sequence where each number is divided by the <c>divisor</c> individually.
		/// </summary>
		public static IEnumerable<double> Divide(this IList<double> values, double divisor)
		{
			for(int i = Int.Zero; i < values.Count; i++)
			{
				yield return values[i] / divisor;
			}
		}
	}
}