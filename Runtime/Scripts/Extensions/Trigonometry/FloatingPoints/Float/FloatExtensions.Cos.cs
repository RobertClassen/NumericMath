namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static float Acos(this float cos, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Acos(cos).ToDegrees(isDegrees);
		}

		public static float Cos(this float angle, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Cos(angle.ToRadians(isDegrees));
		}

		public static float Cosh(this float hyperbolicAngle)
		{
			return (float)Math.Cosh(hyperbolicAngle);
		}
	}
}