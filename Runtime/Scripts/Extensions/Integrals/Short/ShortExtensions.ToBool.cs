namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class ShortExtensions
	{
		public static bool ToBool(this short value)
		{
			return value != Short.Zero;
		}
	}
}