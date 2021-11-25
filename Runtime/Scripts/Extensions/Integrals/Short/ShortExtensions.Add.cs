namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ShortExtensions
	{
		public static short Add(this short start, short increment)
		{
			return (short)(start + increment);
		}

		public static IEnumerable<short> Add(this short start, short increment, int count)
		{
			if(count < Int.Zero)
			{
				throw new ArgumentLessThanZeroException();
			}
			for(int i = Int.Zero; i < count; i++)
			{
				yield return start += increment;
			}
		}
	}
}