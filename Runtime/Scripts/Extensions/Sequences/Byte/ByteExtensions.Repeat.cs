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

		/// <summary>
		/// Returns the sequence a specified number of times.
		/// </summary>
		/// 
		/// <example>
		/// <code>
		/// var range = 0.Range(5).ToArray(); // returns '[0, 1, 2, 3, 4]'
		/// range.Repeat(3);                  // returns '0, 1, 2, 3, 4, 0, 1, 2, 3, 4, 0, 1, 2, 3, 4'
		/// range.Repeat(3, true);            // returns '0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4'
		/// </code>
		/// </example>
		/// 
		/// <param name="values">The sequence to be repeated.</param>
		/// <param name="count">The number of times the sequence should be repeated.</param>
		/// <param name="byIndex">
		/// Repeats the number at each index individually by the specified number of times if set to <c>true</c>, 
		/// else iterates the sequence repeatedly as a whole.
		/// </param>
		public static IEnumerable<byte> Repeat(this IList<byte> values, int count, bool byIndex = Numeric.RepeatByIndexDefault)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException(nameof(count), count);
			}
			int length = values.Count;
			if(byIndex)
			{
				for(int i = Int.Zero; i < length; i++)
				{
					for(int c = Int.Zero; c < count; c++)
					{
						yield return values[i];
					}
				}
			}
			else
			{
				for(int c = Int.Zero; c < count; c++)
				{
					for(int i = Int.Zero; i < length; i++)
					{
						yield return values[i];
					}
				}
			}
		}
	}
}