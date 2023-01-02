namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>multiplicand</c> is individually multiplied by the first number, 
		/// or the previous product, respectively.
		/// </summary>
		public static IEnumerable<float> Multiply(this float value, IList<float> multiplicands, 
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
		public static IEnumerable<float> Multiply(this float value, params float[] multiplicands)
		{
			return value.Multiply((IList<float>)multiplicands);
		}

		/// <summary>
		/// Returns a sequence where each <c>multiplicand</c> is individually multiplied by the first number, 
		/// or the previous product, respectively.
		/// </summary>
		public static IEnumerable<float> Multiply(this float value, IEnumerable<float> multiplicands, 
			bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(float multiplicand in multiplicands)
				{
					yield return value *= multiplicand;
				}
			}
			else
			{
				foreach(float multiplicand in multiplicands)
				{
					yield return value * multiplicand;
				}
			}
		}
	}
}