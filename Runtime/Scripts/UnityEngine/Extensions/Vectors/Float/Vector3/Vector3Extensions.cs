namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		#region Constants
		private const double delta = 1E-05;
		#endregion

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
		/// If set to <c>true</c> the returned angle is never greater than 180 degrees or smaller than -180 degrees.<br/>
		/// If set to <c>false</c> the returned angle is never greater than 180 degrees.<br/>
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
			return Math.Abs(vector.sqrMagnitude - Float.One) < delta;
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
		/// Performs a component-wise `Sign` operation.
		/// </summary>
		public static Vector3 Sign(this Vector3 vector)
		{
			return new Vector3(vector.x.Sign(), vector.y.Sign(), vector.z.Sign());
		}
		#endregion
	}
}