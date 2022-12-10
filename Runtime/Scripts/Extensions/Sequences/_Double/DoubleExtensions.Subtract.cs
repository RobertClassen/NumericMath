namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class doubleExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>subtrahend</c> is individually subtracted from the first number, 
		/// or the previous difference, respectively.
		/// </summary>
		public static IEnumerable<double> Subtract(this double value, IList<double> subtrahends, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
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
		public static IEnumerable<double> Subtract(this double value, params double[] subtrahends)
		{
			return value.Subtract((IList<double>)subtrahends);
		}

		/// <summary>
		/// Returns a sequence where each <c>subtrahend</c> is individually subtracted from the first number, 
		/// or the previous difference, respectively.
		/// </summary>
		public static IEnumerable<double> Subtract(this double value, IEnumerable<double> subtrahends, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(double subtrahend in subtrahends)
				{
					yield return value -= subtrahend;
				}
			}
			else
			{
				foreach(double subtrahend in subtrahends)
				{
					yield return value - subtrahend;
				}
			}
		}
	}
}