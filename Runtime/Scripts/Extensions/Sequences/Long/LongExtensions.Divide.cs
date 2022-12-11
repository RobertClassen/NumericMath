namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class LongExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>divisor</c> is individually dividing the first number, 
		/// or the previous quotient, respectively.
		/// </summary>
		public static IEnumerable<long> Divide(this long value, IList<long> divisors, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
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
		public static IEnumerable<long> Divide(this long value, params long[] divisors)
		{
			return value.Divide((IList<long>)divisors);
		}

		/// <summary>
		/// Returns a sequence where each <c>divisor</c> is individually dividing the first number, 
		/// or the previous quotient, respectively.
		/// </summary>
		public static IEnumerable<long> Divide(this long value, IEnumerable<long> divisors, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(long divisor in divisors)
				{
					yield return value /= divisor;
				}
			}
			else
			{
				foreach(long divisor in divisors)
				{
					yield return value / divisor;
				}
			}
		}
	}
}