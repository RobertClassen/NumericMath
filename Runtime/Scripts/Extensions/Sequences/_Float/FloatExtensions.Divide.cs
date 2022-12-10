namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class floatExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>divisor</c> is individually dividing the first number, 
		/// or the previous quotient, respectively.
		/// </summary>
		public static IEnumerable<float> Divide(this float value, IList<float> divisors, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
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
		public static IEnumerable<float> Divide(this float value, params float[] divisors)
		{
			return value.Divide((IList<float>)divisors);
		}

		/// <summary>
		/// Returns a sequence where each <c>divisor</c> is individually dividing the first number, 
		/// or the previous quotient, respectively.
		/// </summary>
		public static IEnumerable<float> Divide(this float value, IEnumerable<float> divisors, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(float divisor in divisors)
				{
					yield return value /= divisor;
				}
			}
			else
			{
				foreach(float divisor in divisors)
				{
					yield return value / divisor;
				}
			}
		}
	}
}