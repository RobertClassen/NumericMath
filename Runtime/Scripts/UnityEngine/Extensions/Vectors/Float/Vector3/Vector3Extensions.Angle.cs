namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
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
		public static float Angle(this Vector3 from, Vector3 to, Vector3 axis, bool isSigned = Numeric.IsAngleSignedDefault)
		{
			return isSigned ? Vector3.SignedAngle(from, to, axis) : Vector3.Angle(from, to);
		}

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
		/// If set to <c>true</c> the returned angle is never greater than 180 degrees or smaller than -180 degrees.<br/>
		/// If set to <c>false</c> the returned angle is never greater than 180 degrees.<br/>
		/// </param>
		public static float Angle(this Vector3 from, Vector3 to, bool isSigned = Numeric.IsAngleSignedDefault)
		{
			from.Normalize();
			to.Normalize();
			return from.Dot(to) > -Float.One + Numeric.MagnitudeDelta ? from.Angle(to, from.Cross(to), isSigned) : 180f;
		}

		/// <summary>
		/// Creates a <c>Quaternion</c> which rotates <c>angle</c> degrees around <c>axis</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Quaternion.AngleAxis.html
		/// </remarks>
		public static Quaternion AngleAxis(this Vector3 axis, float angle)
		{
			return Quaternion.AngleAxis(angle, axis);
		}
	}
}