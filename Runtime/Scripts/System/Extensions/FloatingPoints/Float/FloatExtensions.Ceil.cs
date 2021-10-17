namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Ceil(this float value)
		{
			return (float)Math.Ceiling(value);
		}

		public static int CeilToInt(this float value)
		{
			return (int)value.Ceil();
		}
	}
}