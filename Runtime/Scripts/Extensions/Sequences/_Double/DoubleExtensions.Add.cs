namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>addend</c> is individually added to the first number, 
		/// or the previous sum, respectively.
		/// </summary>
		public static IEnumerable<double> Add(this double value, IList<double> addends, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
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
		public static IEnumerable<double> Add(this double value, params double[] addends)
		{
			return value.Add((IList<double>)addends);
		}

		/// <summary>
		/// Returns a sequence where each <c>addend</c> is individually added to the first number, 
		/// or the previous sum, respectively.
		/// </summary>
		public static IEnumerable<double> Add(this double value, IEnumerable<double> addends, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(double addend in addends)
				{
					yield return value += addend;
				}
			}
			else
			{
				foreach(double addend in addends)
				{
					yield return value + addend;
				}
			}
		}
	}
}