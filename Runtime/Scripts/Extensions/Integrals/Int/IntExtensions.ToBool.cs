namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class IntExtensions
	{
		public static bool ToBool(this int value)
		{
			return value != Int.Zero;
		}
	}
}