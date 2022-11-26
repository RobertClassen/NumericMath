namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
		/// <summary>
		/// Returns the angle whose tangent is the number.
		/// </summary>
		/// <remarks>
		/// @see https://docs.microsoft.com/en-us/dotnet/api/system.math.atan  
		/// @see https://docs.unity3d.com/ScriptReference/Mathf.Atan.html
		/// </remarks>
		/// <param name="tan">The tangent value to convert to an angle.</param>
		/// <param name="toDegrees">If set to <c>false</c> the <c>angle</c> is returned in <c>radians</c>, else in <c>degrees</c>.</param>
		public static double Atan(this double tan, bool toDegrees = Angle.IsDegreesDefault)
		{
			return Math.Atan(tan).ToDegrees(toDegrees);
		}

		/// <summary>
		/// Returns the angle whose tangent is <c>y/x</c> 
		/// (the angle between the x-axis and a 2D vector from <c>(0,0)</c> to <c>(x,y)</c>).
		/// </summary>
		/// <remarks>
		/// Accounts for cases where <c>x</c> is <c>zero</c> and returns the correct angle 
		/// rather than throwing a <c>DivideByZeroException</c>.  
		/// @see https://docs.microsoft.com/en-us/dotnet/api/system.math.atan2  
		/// @see https://docs.unity3d.com/ScriptReference/Mathf.Atan2.html
		/// </remarks>
		/// <param name="y">The y-coordinate of the vector.</param>
		/// <param name="x">The x-coordinate of the vector.</param>
		/// <param name="toDegrees">If set to <c>false</c> the <c>angle</c> is returned in <c>radians</c>, else in <c>degrees</c>.</param>
		public static double Atan2(this double y, double x, bool toDegrees = Angle.IsDegreesDefault)
		{
			return Math.Atan2(y, x).ToDegrees(toDegrees);
		}

		/// <summary>
		/// Returns the tangent of the angle.
		/// </summary>
		/// <remarks>
		/// @see https://docs.microsoft.com/en-us/dotnet/api/system.math.tan  
		/// @see https://docs.unity3d.com/ScriptReference/Mathf.Tan.html
		/// </remarks>
		/// <param name="angle">The angle to convert to a tangent value.</param>
		/// <param name="fromDegrees">If set to <c>false</c> the <c>angle</c> is assumed to be in <c>radians</c>, else in <c>degrees</c>.</param>
		public static double Tan(this double angle, bool fromDegrees = Angle.IsDegreesDefault)
		{
			return Math.Tan(angle.ToRadians(fromDegrees));
		}

		/// <summary>
		/// Returns the hyperbolic tangent of the angle.
		/// </summary>
		/// <remarks>
		/// @see https://docs.microsoft.com/en-us/dotnet/api/system.math.tanh
		/// </remarks>
		/// <param name="angle">The angle to convert to a hyperbolic tangent value.</param>
		/// <param name="fromDegrees">If set to <c>false</c> the <c>angle</c> is assumed to be in <c>radians</c>, else in <c>degrees</c>.</param>
		public static double Tanh(this double angle, bool fromDegrees = Angle.IsDegreesDefault)
		{
			return Math.Tanh(angle.ToRadians(fromDegrees));
		}
	}
}