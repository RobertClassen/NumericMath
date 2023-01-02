namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ShortExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>addend</c> is individually added to the first number, 
		/// or the previous sum, respectively.
		/// </summary>
		public static IEnumerable<short> Add(this short value, IList<short> addends, 
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
					yield return (short)(value + addends[i]);
				}
			}
		}

		/// <summary>
		/// Returns a sequence where each <c>addend</c> is added to the first number individually.
		/// </summary>
		public static IEnumerable<short> Add(this short value, params short[] addends)
		{
			return value.Add((IList<short>)addends);
		}

		/// <summary>
		/// Returns a sequence where each <c>addend</c> is individually added to the first number, 
		/// or the previous sum, respectively.
		/// </summary>
		public static IEnumerable<short> Add(this short value, IEnumerable<short> addends, 
			bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(short addend in addends)
				{
					yield return value += addend;
				}
			}
			else
			{
				foreach(short addend in addends)
				{
					yield return (short)(value + addend);
				}
			}
		}
	}
}