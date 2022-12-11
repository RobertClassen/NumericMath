namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class IntExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>divisor</c> is individually dividing the first number, 
		/// or the previous quotient, respectively.
		/// </summary>
		public static IEnumerable<int> Divide(this int value, IList<int> divisors, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				for(int i = Int.Zero; i < divisors.Count; i++)
				{
					yield return value /= divisors[i];
				}
			}
			else
			{
				for(int i = Int.Zero; i < divisors.Count; i++)
				{
					yield return value / divisors[i];
				}
			}
		}

		/// <summary>
		/// Returns a sequence where each <c>divisor</c> is dividing the first number individually.
		/// </summary>
		public static IEnumerable<int> Divide(this int value, params int[] divisors)
		{
			return value.Divide((IList<int>)divisors);
		}

		/// <summary>
		/// Returns a sequence where each <c>divisor</c> is individually dividing the first number, 
		/// or the previous quotient, respectively.
		/// </summary>
		public static IEnumerable<int> Divide(this int value, IEnumerable<int> divisors, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(int divisor in divisors)
				{
					yield return value /= divisor;
				}
			}
			else
			{
				foreach(int divisor in divisors)
				{
					yield return value / divisor;
				}
			}
		}
	}
}