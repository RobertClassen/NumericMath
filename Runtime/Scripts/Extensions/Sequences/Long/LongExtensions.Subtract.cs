namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class LongExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>subtrahend</c> is individually subtracted from the first number, 
		/// or the previous difference, respectively.
		/// </summary>
		public static IEnumerable<long> Subtract(this long value, IList<long> subtrahends, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				for(int i = Int.Zero; i < subtrahends.Count; i++)
				{
					yield return value -= subtrahends[i];
				}
			}
			else
			{
				for(int i = Int.Zero; i < subtrahends.Count; i++)
				{
					yield return value - subtrahends[i];
				}
			}
		}

		/// <summary>
		/// Returns a sequence where each <c>subtrahend</c> is subtracted from the first number individually.
		/// </summary>
		public static IEnumerable<long> Subtract(this long value, params long[] subtrahends)
		{
			return value.Subtract((IList<long>)subtrahends);
		}

		/// <summary>
		/// Returns a sequence where each <c>subtrahend</c> is individually subtracted from the first number, 
		/// or the previous difference, respectively.
		/// </summary>
		public static IEnumerable<long> Subtract(this long value, IEnumerable<long> subtrahends, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(long subtrahend in subtrahends)
				{
					yield return value -= subtrahend;
				}
			}
			else
			{
				foreach(long subtrahend in subtrahends)
				{
					yield return value - subtrahend;
				}
			}
		}
	}
}