namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		/// <summary>
		/// Returns a sequence of numbers (<b>including</b> the initial value) with a specified length.
		/// </summary>
		/// <param name="start">The first value to be returned.</param>
		/// <param name="count">The number of values to be returned.</param>
		/// <param name="increment">The step size between the returned values.</param>
		public static IEnumerable<byte> Range(this byte start, int count, byte increment = Byte.One)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException(nameof(count), count);
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return start;
				start += increment;
			}
		}
	}
}