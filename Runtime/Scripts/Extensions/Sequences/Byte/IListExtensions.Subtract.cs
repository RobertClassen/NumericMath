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
		public static IEnumerable<byte> Subtract(this IList<byte> values, byte subtrahend)
		{
			for(int i = Int.Zero; i < values.Count; i++)
			{
				yield return (byte)(values[i] - subtrahend);
			}
		}
	}
}