namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
		public static Vector3 Abs(this Vector3 vector)
		{
			return new Vector3(vector.x.Abs(), vector.y.Abs(), vector.z.Abs());
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
		/// If set to <c>true</c> the returned angle is never greater than 180° or smaller than -180°.<br/>
		/// If set to <c>false</c> the returned angle is never greater than 180°.<br/>
		/// </param>
		public static float Angle(this Vector3 from, Vector3 to, Vector3 axis, bool isSigned = Core.Numeric.IsAngleSignedDefault)
		{
			return isSigned ? Vector3.SignedAngle(from, to, axis) : Vector3.Angle(from, to);
		}

		/// <summary>
		/// Returns the distance between both vectors.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector3.Distance.html
		/// </remarks>
		public static float Distance(this Vector3 vector, Vector3 other)
		{
			float x = vector.x - other.x;
			float y = vector.y - other.y;
			float z = vector.z - other.z;
			return (float)Math.Sqrt((double)(x * x + y * y + z * z));
		}

		/// <summary>
		/// Checks if the magnitude of the <c>vector</c> equals <c>1</c>.
		/// </summary>
		public static bool IsNormalized(this Vector3 vector)
		{
			return Math.Abs(vector.sqrMagnitude - Float.One) < Core.Numeric.MagnitudeDelta;
		}

		/// <summary>
		/// Linearly interpolates between both vectors by <c>t</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector3.LerpUnclamped.html  
		/// See https://docs.unity3d.com/ScriptReference/Vector3.Lerp.html
		/// </remarks>
		public static Vector3 Lerp(this Vector3 vector, Vector3 other, float t = Float.OneHalf, 
			bool isClamped = Core.Numeric.IsLerpClampedDefault)
		{
			return new Vector3(
				t.Lerp(vector.x, other.x, isClamped), 
				t.Lerp(vector.y, other.y, isClamped), 
				t.Lerp(vector.z, other.z, isClamped));
		}

		/// <summary>
		/// Returns a vector that is made from the largest components of two vectors.
		/// </summary>
		/// <seealso cref="Min"/>
		public static Vector3 Max(this Vector3 vector, Vector3 other)
		{
			return new Vector3(vector.x.Max(other.x), vector.y.Max(other.y), vector.z.Max(other.z));
		}

		/// <summary>
		/// Returns a vector that is made from the smallest components of two vectors.
		/// </summary>
		/// <seealso cref="Max"/>
		public static Vector3 Min(this Vector3 vector, Vector3 other)
		{
			return new Vector3(vector.x.Min(other.x), vector.y.Min(other.y), vector.z.Min(other.z));
		}

		/// <summary>
		/// Moves the point current towards the <c>target</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector3.MoveTowards.html
		/// </remarks>
		public static Vector3 MoveTowards(this Vector3 point, Vector3 target, float maxDistanceDelta)
		{
			return Vector3.MoveTowards(point, target, maxDistanceDelta);
		}

		/// <summary>
		/// Performs a component-wise `Sign` operation.
		/// </summary>
		public static Vector3 Sign(this Vector3 vector)
		{
			return new Vector3(vector.x.Sign(), vector.y.Sign(), vector.z.Sign());
		}

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
		#endregion
	}
}