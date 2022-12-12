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
		public static IEnumerable<byte> Divide(this IList<byte> values, byte divisor)
		{
			for(int i = Int.Zero; i < values.Count; i++)
			{
				yield return (byte)(values[i] / divisor);
			}
		}
	}
}