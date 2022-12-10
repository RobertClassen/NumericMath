namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class doubleExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>multiplicand</c> is individually multiplied by the first number, 
		/// or the previous product, respectively.
		/// </summary>
		public static IEnumerable<double> Multiply(this double value, IList<double> multiplicands, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				for(int i = Int.Zero; i < multiplicands.Count; i++)
				{
					yield return value *= multiplicands[i];
				}
			}
			else
			{
				for(int i = Int.Zero; i < multiplicands.Count; i++)
				{
					yield return value * multiplicands[i];
				}
			}
		}

		/// <summary>
		/// Returns a sequence where each <c>multiplicand</c> is multiplied by the first number individually.
		/// </summary>
		public static IEnumerable<double> Multiply(this double value, params double[] multiplicands)
		{
			return value.Multiply((IList<double>)multiplicands);
		}

		/// <summary>
		/// Returns a sequence where each <c>multiplicand</c> is individually multiplied by the first number, 
		/// or the previous product, respectively.
		/// </summary>
		public static IEnumerable<double> Multiply(this double value, IEnumerable<double> multiplicands, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(double multiplicand in multiplicands)
				{
					yield return value *= multiplicand;
				}
			}
			else
			{
				foreach(double multiplicand in multiplicands)
				{
					yield return value * multiplicand;
				}
			}
		}
	}
}