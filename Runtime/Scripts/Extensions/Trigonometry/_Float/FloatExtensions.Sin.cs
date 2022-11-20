namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static float Asin(this float sin, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Asin(sin).ToDegrees(isDegrees);
		}

		public static float Sin(this float angle, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Sin(angle.ToRadians(isDegrees));
		}

		public static float Sinh(this float hyperbolicAngle)
		{
			return (float)Math.Sinh(hyperbolicAngle);
		}
	}
}