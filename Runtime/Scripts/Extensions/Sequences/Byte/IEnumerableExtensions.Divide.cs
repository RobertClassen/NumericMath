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
		public static IEnumerable<byte> Divide(this IEnumerable<byte> values, byte divisor)
		{
			foreach(byte value in values)
			{
				yield return (byte)(value / divisor);
			}
		}
	}
}