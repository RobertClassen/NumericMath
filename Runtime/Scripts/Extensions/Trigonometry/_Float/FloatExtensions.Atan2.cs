namespace NumericMath
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;

	public static partial class FloatExtensions
	{
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
		public static float Atan2(this float y, float x, bool toDegrees = Angle.IsDegreesDefault)
		{
			return (float)Math.Atan2(y, x).ToDegrees(toDegrees);
		}
	}
}