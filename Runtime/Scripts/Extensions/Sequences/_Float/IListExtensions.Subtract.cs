namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IListExtensions
	{
		/// <summary>
		/// Returns a sequence where the <c>subtrahend</c> is subtracted from each number individually.
		/// </summary>
		public static IEnumerable<float> Subtract(this IList<float> values, float subtrahend)
		{
			for(int i = Int.Zero; i < values.Count; i++)
			{
				yield return values[i] - subtrahend;
			}
		}
	}
}