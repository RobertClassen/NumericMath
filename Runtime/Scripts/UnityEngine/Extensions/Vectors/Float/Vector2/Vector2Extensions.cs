namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
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
		/// If set to <c>true</c> the returned angle is never greater than 180 degrees or smaller than -180 degrees.<br/>
		/// If set to <c>false</c> the returned angle is never greater than 180 degrees.<br/>
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
			return Math.Abs(vector.sqrMagnitude - Float.One) < delta;
		}

		/// <summary>
		/// Performs a component-wise `Sign` operation.
		/// </summary>
		public static Vector2 Sign(this Vector2 vector)
		{
			return new Vector2(vector.x.Sign(), vector.y.Sign());
		}
		#endregion
	}
}