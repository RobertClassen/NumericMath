namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ByteExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>multiplicand</c> is individually multiplied by the first number, 
		/// or the previous product, respectively.
		/// </summary>
		public static IEnumerable<byte> Multiply(this byte value, IList<byte> multiplicands, 
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
					yield return (byte)(value * multiplicands[i]);
				}
			}
		}

		/// <summary>
		/// Returns a sequence where each <c>multiplicand</c> is multiplied by the first number individually.
		/// </summary>
		public static IEnumerable<byte> Multiply(this byte value, params byte[] multiplicands)
		{
			return value.Multiply((IList<byte>)multiplicands);
		}

		/// <summary>
		/// Returns a sequence where each <c>multiplicand</c> is individually multiplied by the first number, 
		/// or the previous product, respectively.
		/// </summary>
		public static IEnumerable<byte> Multiply(this byte value, IEnumerable<byte> multiplicands, 
			bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(byte multiplicand in multiplicands)
				{
					yield return value *= multiplicand;
				}
			}
			else
			{
				foreach(byte multiplicand in multiplicands)
				{
					yield return (byte)(value * multiplicand);
				}
			}
		}
	}
}