namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Acos(this float value)
		{
			return (float)Math.Acos(value);
		}

		public static float Cos(this float value)
		{
			return (float)Math.Cos(value);
		}

		public static float Cosh(this float value)
		{
			return (float)Math.Cosh(value);
		}
	}
}