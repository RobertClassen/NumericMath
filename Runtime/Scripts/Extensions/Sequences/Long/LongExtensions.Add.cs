namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class LongExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>addend</c> is individually added to the first number, 
		/// or the previous sum, respectively.
		/// </summary>
		public static IEnumerable<long> Add(this long value, IList<long> addends, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
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
		public static IEnumerable<long> Add(this long value, params long[] addends)
		{
			return value.Add((IList<long>)addends);
		}

		/// <summary>
		/// Returns a sequence where each <c>addend</c> is individually added to the first number, 
		/// or the previous sum, respectively.
		/// </summary>
		public static IEnumerable<long> Add(this long value, IEnumerable<long> addends, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(long addend in addends)
				{
					yield return value += addend;
				}
			}
			else
			{
				foreach(long addend in addends)
				{
					yield return value + addend;
				}
			}
		}
	}
}