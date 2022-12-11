namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class LongExtensions
	{
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
		public static IEnumerable<long> Repeat(this IList<long> values, int count, bool byIndex = Numeric.RepeatByIndexDefault)
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