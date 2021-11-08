namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		public static float Atan(this float tan, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Atan(tan.ToRadians(isDegrees));
		}

		public static float Atan2(this float y, float x, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Atan2(y, x).ToDegrees(isDegrees);
		}

		public static float Tan(this float angle, bool isDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Tan(angle.ToRadians(isDegrees));
		}

		public static float Tanh(this float hyperbolicAngle)
		{
			return (float)Math.Tanh(hyperbolicAngle);
		}
	}
}