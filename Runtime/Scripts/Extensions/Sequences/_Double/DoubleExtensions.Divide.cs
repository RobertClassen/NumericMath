namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>divisor</c> is individually dividing the first number, 
		/// or the previous quotient, respectively.
		/// </summary>
		public static IEnumerable<double> Divide(this double value, IList<double> divisors, 
			bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
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
		public static IEnumerable<double> Divide(this double value, params double[] divisors)
		{
			return value.Divide((IList<double>)divisors);
		}

		/// <summary>
		/// Returns a sequence where each <c>divisor</c> is individually dividing the first number, 
		/// or the previous quotient, respectively.
		/// </summary>
		public static IEnumerable<double> Divide(this double value, IEnumerable<double> divisors, 
			bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(double divisor in divisors)
				{
					yield return value /= divisor;
				}
			}
			else
			{
				foreach(double divisor in divisors)
				{
					yield return value / divisor;
				}
			}
		}
	}
}