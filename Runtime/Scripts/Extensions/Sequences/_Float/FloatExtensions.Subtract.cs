namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class floatExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>subtrahend</c> is individually subtracted from the first number, 
		/// or the previous difference, respectively.
		/// </summary>
		public static IEnumerable<float> Subtract(this float value, IList<float> subtrahends, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
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
		public static IEnumerable<float> Subtract(this float value, params float[] subtrahends)
		{
			return value.Subtract((IList<float>)subtrahends);
		}

		/// <summary>
		/// Returns a sequence where each <c>subtrahend</c> is individually subtracted from the first number, 
		/// or the previous difference, respectively.
		/// </summary>
		public static IEnumerable<float> Subtract(this float value, IEnumerable<float> subtrahends, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(float subtrahend in subtrahends)
				{
					yield return value -= subtrahend;
				}
			}
			else
			{
				foreach(float subtrahend in subtrahends)
				{
					yield return value - subtrahend;
				}
			}
		}
	}
}