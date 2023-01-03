namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ByteExtensions
	{
		public static string ToInvariantString(this byte value, string format = null)
		{
			return value.ToString(format, Culture.Invariant);
		}
	}
}