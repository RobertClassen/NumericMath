namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ShortExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>multiplicand</c> is individually multiplied by the first number, 
		/// or the previous product, respectively.
		/// </summary>
		public static IEnumerable<short> Multiply(this short value, IList<short> multiplicands, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
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
					yield return (short)(value * multiplicands[i]);
				}
			}
		}

		/// <summary>
		/// Returns a sequence where each <c>multiplicand</c> is multiplied by the first number individually.
		/// </summary>
		public static IEnumerable<short> Multiply(this short value, params short[] multiplicands)
		{
			return value.Multiply((IList<short>)multiplicands);
		}

		/// <summary>
		/// Returns a sequence where each <c>multiplicand</c> is individually multiplied by the first number, 
		/// or the previous product, respectively.
		/// </summary>
		public static IEnumerable<short> Multiply(this short value, IEnumerable<short> multiplicands, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(short multiplicand in multiplicands)
				{
					yield return value *= multiplicand;
				}
			}
			else
			{
				foreach(short multiplicand in multiplicands)
				{
					yield return (short)(value * multiplicand);
				}
			}
		}
	}
}