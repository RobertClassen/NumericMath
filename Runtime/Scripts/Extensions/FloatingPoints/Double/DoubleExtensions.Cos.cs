namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		public static double Acos(this double value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return Math.Acos(value.ToRadians(isDegrees));
		}

		public static double Cos(this double value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return Math.Cos(value.ToRadians(isDegrees));
		}

		public static double Cosh(this double value, bool isDegrees = Angle.IsDegreesDefault)
		{
			return Math.Cosh(value.ToRadians(isDegrees));
		}
	}
}