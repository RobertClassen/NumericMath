namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class ByteExtensions
	{
		public static bool ToBool(this byte value)
		{
			return value != Byte.Zero;
		}
	}
}