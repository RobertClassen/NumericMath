namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
		/// <summary>
		/// Returns the angle whose sine is the number.
		/// </summary>
		/// <remarks>
		/// @see https://docs.microsoft.com/en-us/dotnet/api/system.math.asin
		/// @see https://docs.unity3d.com/ScriptReference/Mathf.Asin.html  
		/// </remarks>
		/// <param name="sin">The sine value to convert to an angle.</param>
		/// <param name="toDegrees">If set to <c>false</c> the <c>angle</c> is returned in <c>radians</c>, else in <c>degrees</c>.</param>
		public static float Asin(this float sin, bool toDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Asin(sin).ToDegrees(toDegrees);
		}

		/// <summary>
		/// Returns the sine of the angle.
		/// </summary>
		/// <remarks>
		/// @see https://docs.microsoft.com/en-us/dotnet/api/system.math.sin  
		/// @see https://docs.unity3d.com/ScriptReference/Mathf.Sin.html
		/// </remarks>
		/// <param name="angle">The angle to convert to a sine value.</param>
		/// <param name="fromDegrees">If set to <c>false</c> the <c>angle</c> is assumed to be in <c>radians</c>, else in <c>degrees</c>.</param>
		public static float Sin(this float angle, bool fromDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Sin(angle.ToRadians(fromDegrees));
		}

		/// <summary>
		/// Returns the hyperbolic sine of the angle.
		/// </summary>
		/// <remarks>
		/// @see https://docs.microsoft.com/en-us/dotnet/api/system.math.sinh
		/// </remarks>
		/// <param name="angle">The angle to convert to a hyperbolic sine value.</param>
		/// <param name="fromDegrees">If set to <c>false</c> the <c>angle</c> is assumed to be in <c>radians</c>, else in <c>degrees</c>.</param>
		public static float Sinh(this float angle, bool fromDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Sinh(angle.ToRadians(fromDegrees));
		}
	}
}