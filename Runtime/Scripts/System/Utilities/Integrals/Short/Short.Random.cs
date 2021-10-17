namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class Short
	{
		public static short Random(short min, short max)
		{
			return (short)Int.Random(min, max);
		}
	}
}