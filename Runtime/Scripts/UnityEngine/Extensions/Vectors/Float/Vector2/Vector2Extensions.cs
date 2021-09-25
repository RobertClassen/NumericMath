namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		public static Vector2 Abs(this Vector2 vector)
		{
			return new Vector2(vector.x.Abs(), vector.y.Abs());
		}

		/// <summary>
		/// Returns the signed or unsigned acute angle between the two vectors, in degrees.
		/// </summary>
		/// <remarks>
		/// This means the smaller of the two possible angles between the two vectors is used.
		/// 
		/// See https://docs.unity3d.com/ScriptReference/Vector2.SignedAngle.html  
		/// See https://docs.unity3d.com/ScriptReference/Vector2.Angle.html
		/// </remarks>
		/// <param name="isSigned">
		/// If set to <c>true</c> the returned angle is never greater than 180° or smaller than -180°.<br/>
		/// If set to <c>false</c> the returned angle is never greater than 180°.<br/>
		/// </param>
		public static float Angle(this Vector2 from, Vector2 to, bool isSigned = Core.Numeric.IsAngleSignedDefault)
		{
			return isSigned ? Vector2.SignedAngle(from, to) : Vector2.Angle(from, to);
		}

		/// <summary>
		/// Returns the distance between both vectors.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector2.Distance.html
		/// </remarks>
		public static float Distance(this Vector2 vector, Vector2 other)
		{
			float x = vector.x - other.x;
			float y = vector.y - other.y;
			return (float)Math.Sqrt((double)(x * x + y * y));
		}

		/// <summary>
		/// Checks if the magnitude of the <c>vector</c> equals <c>1</c>.
		/// </summary>
		public static bool IsNormalized(this Vector2 vector)
		{
			return Math.Abs(vector.sqrMagnitude - Float.One) < Core.Numeric.MagnitudeDelta;
		}

		/// <summary>
		/// Linearly interpolates between both vectors by <c>t</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector2.LerpUnclamped.html  
		/// See https://docs.unity3d.com/ScriptReference/Vector2.Lerp.html
		/// </remarks>
		public static Vector2 Lerp(this Vector2 vector, Vector2 other, float t = Float.OneHalf, 
			bool isClamped = Core.Numeric.IsLerpClampedDefault)
		{
			return new Vector2(
				t.Lerp(vector.x, other.x, isClamped), 
				t.Lerp(vector.y, other.y, isClamped));
		}

		/// <summary>
		/// Returns a vector that is made from the largest components of two vectors.
		/// </summary>
		/// <seealso cref="Min"/>
		public static Vector2 Max(this Vector2 vector, Vector2 other)
		{
			return new Vector2(vector.x.Max(other.x), vector.y.Max(other.y));
		}

		/// <summary>
		/// Returns a vector that is made from the smallest components of two vectors.
		/// </summary>
		/// <seealso cref="Max"/>
		public static Vector2 Min(this Vector2 vector, Vector2 other)
		{
			return new Vector2(vector.x.Min(other.x), vector.y.Min(other.y));
		}

		/// <summary>
		/// Moves the point current towards the <c>target</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector2.MoveTowards.html
		/// </remarks>
		public static Vector2 MoveTowards(this Vector2 point, Vector2 target, float maxDistanceDelta)
		{
			return Vector2.MoveTowards(point, target, maxDistanceDelta);
		}

		/// <summary>
		/// Performs a component-wise `Sign` operation.
		/// </summary>
		public static Vector2 Sign(this Vector2 vector)
		{
			return new Vector2(vector.x.Sign(), vector.y.Sign());
		}

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