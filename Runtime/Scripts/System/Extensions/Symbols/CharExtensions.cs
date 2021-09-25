namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class CharExtensions
	{
		public static bool IsClamped(this char value, char min, char max, bool isInclusive = true)
		{
			return isInclusive ? min <= value && value <= max : min < value && value < max;
		}
	}
}