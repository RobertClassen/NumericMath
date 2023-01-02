namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ShortExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>subtrahend</c> is individually subtracted from the first number, 
		/// or the previous difference, respectively.
		/// </summary>
		public static IEnumerable<short> Subtract(this short value, IList<short> subtrahends, 
			bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
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
					yield return (short)(value - subtrahends[i]);
				}
			}
		}

		/// <summary>
		/// Returns a sequence where each <c>subtrahend</c> is subtracted from the first number individually.
		/// </summary>
		public static IEnumerable<short> Subtract(this short value, params short[] subtrahends)
		{
			return value.Subtract((IList<short>)subtrahends);
		}

		/// <summary>
		/// Returns a sequence where each <c>subtrahend</c> is individually subtracted from the first number, 
		/// or the previous difference, respectively.
		/// </summary>
		public static IEnumerable<short> Subtract(this short value, IEnumerable<short> subtrahends, 
			bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(short subtrahend in subtrahends)
				{
					yield return value -= subtrahend;
				}
			}
			else
			{
				foreach(short subtrahend in subtrahends)
				{
					yield return (short)(value - subtrahend);
				}
			}
		}
	}
}