namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class IntExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>addend</c> is individually added to the first number, 
		/// or the previous sum, respectively.
		/// </summary>
		public static IEnumerable<int> Add(this int value, IList<int> addends, 
			bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				for(int i = Int.Zero; i < addends.Count; i++)
				{
					yield return value += addends[i];
				}
			}
			else
			{
				for(int i = Int.Zero; i < addends.Count; i++)
				{
					yield return value + addends[i];
				}
			}
		}

		/// <summary>
		/// Returns a sequence where each <c>addend</c> is added to the first number individually.
		/// </summary>
		public static IEnumerable<int> Add(this int value, params int[] addends)
		{
			return value.Add((IList<int>)addends);
		}

		/// <summary>
		/// Returns a sequence where each <c>addend</c> is individually added to the first number, 
		/// or the previous sum, respectively.
		/// </summary>
		public static IEnumerable<int> Add(this int value, IEnumerable<int> addends, 
			bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(int addend in addends)
				{
					yield return value += addend;
				}
			}
			else
			{
				foreach(int addend in addends)
				{
					yield return value + addend;
				}
			}
		}
	}
}