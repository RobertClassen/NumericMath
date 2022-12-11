namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ByteExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>subtrahend</c> is individually subtracted from the first number, 
		/// or the previous difference, respectively.
		/// </summary>
		public static IEnumerable<byte> Subtract(this byte value, IList<byte> subtrahends, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				for(int i = Int.Zero; i < subtrahends.Count; i++)
				{
					yield return value -= subtrahends[i];
				}
			}
			else
			{
				for(int i = Int.Zero; i < subtrahends.Count; i++)
				{
					yield return (byte)(value - subtrahends[i]);
				}
			}
		}

		/// <summary>
		/// Returns a sequence where each <c>subtrahend</c> is subtracted from the first number individually.
		/// </summary>
		public static IEnumerable<byte> Subtract(this byte value, params byte[] subtrahends)
		{
			return value.Subtract((IList<byte>)subtrahends);
		}

		/// <summary>
		/// Returns a sequence where each <c>subtrahend</c> is individually subtracted from the first number, 
		/// or the previous difference, respectively.
		/// </summary>
		public static IEnumerable<byte> Subtract(this byte value, IEnumerable<byte> subtrahends, bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(byte subtrahend in subtrahends)
				{
					yield return value -= subtrahend;
				}
			}
			else
			{
				foreach(byte subtrahend in subtrahends)
				{
					yield return (byte)(value - subtrahend);
				}
			}
		}
	}
}