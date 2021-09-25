namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static bool ToBool(this float value)
		{
			return value != Float.Zero;
		}
	}
}