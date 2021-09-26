namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		/// <summary>
		/// Gradually changes the point towards the <c>target</c> over time.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector2.SmoothDamp.html
		/// </remarks>
		public static Vector2 SmoothDamp(this Vector2 point, Vector2 target, 
			ref Vector2 currentVelocity, float smoothTime, 
			float maxSpeed = Mathf.Infinity)
		{
			return Vector2.SmoothDamp(point, target, ref currentVelocity, smoothTime, maxSpeed, Time.deltaTime);
		}

		/// <summary>
		/// Gradually changes the point towards the <c>target</c> over time.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector2.SmoothDamp.html
		/// </remarks>
		public static Vector2 SmoothDamp(this Vector2 point, Vector2 target, 
			ref Vector2 currentVelocity, float smoothTime, 
			float maxSpeed, float deltaTime)
		{
			return Vector2.SmoothDamp(point, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}
	}
}