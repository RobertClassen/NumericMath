namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Returns the signed or unsigned acute angle between the two vectors, in degrees.
		/// </summary>
		/// <remarks>
		/// This means the smaller of the two possible angles between the two vectors is used.
		/// 
		/// See https://docs.unity3d.com/ScriptReference/Vector3.SignedAngle.html  
		/// See https://docs.unity3d.com/ScriptReference/Vector3.Angle.html
		/// </remarks>
		/// <param name="isSigned">
		/// If set to <c>true</c> the returned angle is never greater than 180° or smaller than -180°.<br/>
		/// If set to <c>false</c> the returned angle is never greater than 180°.<br/>
		/// </param>
		public static float Angle(this Vector3 from, Vector3 to, Vector3 axis, bool isSigned = Core.Numeric.IsAngleSignedDefault)
		{
			return isSigned ? Vector3.SignedAngle(from, to, axis) : Vector3.Angle(from, to);
		}
	}
}