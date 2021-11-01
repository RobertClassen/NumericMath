namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static float Asin(this float value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Asin(value.ToRadians(isDegrees));
		}

		public static float Sin(this float value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Sin(value.ToRadians(isDegrees));
		}

		public static float Sinh(this float value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Sinh(value.ToRadians(isDegrees));
		}
	}
}