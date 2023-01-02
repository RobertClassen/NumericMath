namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class LongExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>multiplicand</c> is individually multiplied by the first number, 
		/// or the previous product, respectively.
		/// </summary>
		public static IEnumerable<long> Multiply(this long value, IList<long> multiplicands, 
			bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
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
		public static IEnumerable<long> Multiply(this long value, params long[] multiplicands)
		{
			return value.Multiply((IList<long>)multiplicands);
		}

		/// <summary>
		/// Returns a sequence where each <c>multiplicand</c> is individually multiplied by the first number, 
		/// or the previous product, respectively.
		/// </summary>
		public static IEnumerable<long> Multiply(this long value, IEnumerable<long> multiplicands, 
			bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(long multiplicand in multiplicands)
				{
					yield return value *= multiplicand;
				}
			}
			else
			{
				foreach(long multiplicand in multiplicands)
				{
					yield return value * multiplicand;
				}
			}
		}
	}
}