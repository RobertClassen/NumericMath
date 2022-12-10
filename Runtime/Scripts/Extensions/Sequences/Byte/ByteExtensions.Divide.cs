namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class byteExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>divisor</c> is individually dividing the first number, 
		/// or the previous quotient, respectively.
		/// </summary>
		public static IEnumerable<byte> Divide(this byte value, IList<byte> divisors, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
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
					yield return (byte)(value / divisors[i]);
				}
			}
		}

		/// <summary>
		/// Returns a sequence where each <c>divisor</c> is dividing the first number individually.
		/// </summary>
		public static IEnumerable<byte> Divide(this byte value, params byte[] divisors)
		{
			return value.Divide((IList<byte>)divisors);
		}

		/// <summary>
		/// Returns a sequence where each <c>divisor</c> is individually dividing the first number, 
		/// or the previous quotient, respectively.
		/// </summary>
		public static IEnumerable<byte> Divide(this byte value, IEnumerable<byte> divisors, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(byte divisor in divisors)
				{
					yield return value /= divisor;
				}
			}
			else
			{
				foreach(byte divisor in divisors)
				{
					yield return (byte)(value / divisor);
				}
			}
		}
	}
}