namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		/// <summary>
		/// Returns the angle whose cosine is the number.
		/// </summary>
		/// <remarks>
		/// @see https://docs.microsoft.com/en-us/dotnet/api/system.math.acos  
		/// @see https://docs.unity3d.com/ScriptReference/Mathf.Acos.html
		/// </remarks>
		/// <param name="cos">The cosine value to convert to an angle.</param>
		/// <param name="toDegrees">If set to <c>false</c> the <c>angle</c> is returned in <c>radians</c>, else in <c>degrees</c>.</param>
		public static float Acos(this float cos, bool toDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Acos(cos).ToDegrees(toDegrees);
		}

		/// <summary>
		/// Returns the cosine of the angle.
		/// </summary>
		/// <remarks>
		/// @see https://docs.microsoft.com/en-us/dotnet/api/system.math.cos  
		/// @see https://docs.unity3d.com/ScriptReference/Mathf.Cos.html
		/// </remarks>
		/// <param name="angle">The angle to convert to a cosine value.</param>
		/// <param name="fromDegrees">If set to <c>false</c> the <c>angle</c> is assumed to be in <c>radians</c>, else in <c>degrees</c>.</param>
		public static float Cos(this float angle, bool fromDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Cos(angle.ToRadians(fromDegrees));
		}

		/// <summary>
		/// Returns the hyperbolic cosine of the angle.
		/// </summary>
		/// <remarks>
		/// @see https://docs.microsoft.com/en-us/dotnet/api/system.math.cosh
		/// </remarks>
		/// <param name="angle">The angle to convert to a hyperbolic cosine value.</param>
		/// <param name="fromDegrees">If set to <c>false</c> the <c>angle</c> is assumed to be in <c>radians</c>, else in <c>degrees</c>.</param>
		public static float Cosh(this float angle, bool fromDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Cosh(angle.ToRadians(fromDegrees));
		}
	}
}