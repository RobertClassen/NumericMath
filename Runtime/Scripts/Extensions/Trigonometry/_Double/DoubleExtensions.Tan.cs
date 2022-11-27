namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class DoubleExtensions
	{
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
	}
}