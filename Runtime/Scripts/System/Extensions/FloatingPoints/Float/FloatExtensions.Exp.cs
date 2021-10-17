namespace WellDefinedNumerics
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class FloatExtensions
	{
		public static float Exp(this float value)
		{
			return (float)Math.Exp(value);
		}
	}
}