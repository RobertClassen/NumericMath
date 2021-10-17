namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Floor(this float value)
		{
			return (float)Math.Floor(value);
		}

		public static int FloorToInt(this float value)
		{
			return (int)value.Floor();
		}
	}
}