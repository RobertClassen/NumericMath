namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Atan(this float value)
		{
			return (float)Math.Atan(value);
		}

		public static float Atan2(this float y, float x)
		{
			return (float)Math.Atan2(y, x);
		}

		public static float Tan(this float value)
		{
			return (float)Math.Tan(value);
		}

		public static float Tanh(this float value)
		{
			return (float)Math.Tanh(value);
		}
	}
}