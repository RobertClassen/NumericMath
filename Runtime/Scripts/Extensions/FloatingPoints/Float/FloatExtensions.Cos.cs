namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static float Acos(this float value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Acos(value.ToRadians(isDegrees));
		}

		public static float Cos(this float value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Cos(value.ToRadians(isDegrees));
		}

		public static float Cosh(this float value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Cosh(value.ToRadians(isDegrees));
		}
	}
}