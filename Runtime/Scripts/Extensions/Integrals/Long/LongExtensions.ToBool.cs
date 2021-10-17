namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class LongExtensions
	{
		public static bool ToBool(this long value)
		{
			return value != Long.Zero;
		}
	}
}