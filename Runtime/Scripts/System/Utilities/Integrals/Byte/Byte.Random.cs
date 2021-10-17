namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class Byte
	{
		public static byte Random(byte min, byte max)
		{
			return (byte)Int.Random(min, max);
		}
	}
}