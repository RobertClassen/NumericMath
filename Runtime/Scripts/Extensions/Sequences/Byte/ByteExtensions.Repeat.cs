namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ByteExtensions
	{
		/// <summary>
		/// Returns the same number a specified number of times.
		/// </summary>
		/// 
		/// <remarks>
		/// For `Mathf.Repeat` see <see cref ="Modulo"/> instead. 
		/// (Note the different behavior with negative divisors 
		/// for which `Mathf.Repeat` returns potentially unexpected values.)
		/// 
		/// <example>
		/// <code>
		/// var range = (-3).Range(7);              // returns '-3, -2, -1,  0,  1,  2,  3'
		/// 
		/// range.Select(i => i.Modulo(3));         // returns ' 0,  1,  2,  0,  1,  2,  0'
		/// range.Select(i => i.Remainder(3));      // returns ' 0, -2, -1,  0,  1,  2,  0'
		/// range.Select(i => Mathf.Repeat(i, 3));  // returns ' 0,  1,  2,  0,  1,  2,  0'
		/// 
		/// range.Select(i => i.Modulo(-3));        // returns ' 0, -2, -1,  0, -2, -1,  0'
		/// range.Select(i => i.Remainder(-3));     // returns ' 0, -2, -1,  0,  1,  2,  0'
		/// range.Select(i => Mathf.Repeat(i, -3)); // returns '-3,  0,  0, -3,  0,  0, -3' ◄
		/// </code>
		/// </example>
		/// </remarks>
		/// 
		/// <param name="value">The value to be repeated.</param>
		/// <param name="count">The number of times the value should be repeated.</param>
		public static IEnumerable<byte> Repeat(this byte value, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException(nameof(count), count);
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return value;
			}
		}
	}
}