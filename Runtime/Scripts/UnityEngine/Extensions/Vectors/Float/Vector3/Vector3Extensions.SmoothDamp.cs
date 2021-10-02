namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Gradually changes the point towards the <c>target</c> over time.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector3.SmoothDamp.html
		/// </remarks>
		public static Vector3 SmoothDamp(this Vector3 point, Vector3 target, 
			ref Vector3 currentVelocity, float smoothTime, 
			float maxSpeed = Mathf.Infinity)
		{
			return Vector3.SmoothDamp(point, target, ref currentVelocity, smoothTime, maxSpeed, Time.deltaTime);
		}

		/// <summary>
		/// Gradually changes the point towards the <c>target</c> over time.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector3.SmoothDamp.html
		/// </remarks>
		public static Vector3 SmoothDamp(this Vector3 point, Vector3 target, 
			ref Vector3 currentVelocity, float smoothTime, 
			float maxSpeed, float deltaTime)
		{
			return Vector3.SmoothDamp(point, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}
	}
}