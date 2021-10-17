namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class Byte
	{
		public static IEnumerable<byte> Sequence(byte start, byte increment, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException();
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return start;
				start += increment;
			}
		}
	}
}