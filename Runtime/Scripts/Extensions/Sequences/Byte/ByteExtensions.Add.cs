namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ByteExtensions
	{
		/// <summary>
		/// Returns a sequence where each <c>addend</c> is individually added to the first number, 
		/// or the previous sum, respectively.
		/// </summary>
		public static IEnumerable<byte> Add(this byte value, IList<byte> addends, 
			bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				for(int i = Int.Zero; i < addends.Count; i++)
				{
					yield return value += addends[i];
				}
			}
			else
			{
				for(int i = Int.Zero; i < addends.Count; i++)
				{
					yield return (byte)(value + addends[i]);
				}
			}
		}

		/// <summary>
		/// Returns a sequence where each <c>addend</c> is added to the first number individually.
		/// </summary>
		public static IEnumerable<byte> Add(this byte value, params byte[] addends)
		{
			return value.Add((IList<byte>)addends);
		}

		/// <summary>
		/// Returns a sequence where each <c>addend</c> is individually added to the first number, 
		/// or the previous sum, respectively.
		/// </summary>
		public static IEnumerable<byte> Add(this byte value, IEnumerable<byte> addends, 
			bool iterateOnPrevious = Numeric.IterateOnPreviousDefault)
		{
			if(iterateOnPrevious)
			{
				foreach(byte addend in addends)
				{
					yield return value += addend;
				}
			}
			else
			{
				foreach(byte addend in addends)
				{
					yield return (byte)(value + addend);
				}
			}
		}
	}
}