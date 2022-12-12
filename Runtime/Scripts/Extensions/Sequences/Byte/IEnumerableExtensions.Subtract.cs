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
		public static IEnumerable<byte> Subtract(this IEnumerable<byte> values, byte subtrahend)
		{
			foreach(byte value in values)
			{
				yield return (byte)(value - subtrahend);
			}
		}
	}
}