namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Returns the cross product of two vectors (which in 3d is a perpendicular vector).
		/// </summary>
		/// <remarks>
		/// This operation is anticommutative, i.e. `a.Cross(b) == b.Cross(-a)`.
		/// 
		/// See https://docs.unity3d.com/ScriptReference/Vector3.Cross.html  
		/// See https://en.wikipedia.org/wiki/Cross_product
		/// </remarks>
		public static Vector3 Cross(this Vector3 vector, Vector3 other)
		{
			return Vector3.Cross(vector, other);
		}

		/// <summary>
		/// Returns the cross product of two vectors (which in 2D is the determinant), 
		/// for the <c>x</c> and <c>y</c> components.
		/// </summary>
		/// <remarks>
		/// This operation is anticommutative, i.e. `a.Cross(b) == b.Cross(-a)`.
		/// 
		/// See https://en.wikipedia.org/wiki/Cross_product
		/// </remarks>
		[Obsolete("Use 'DeterminantXY' instead.")]
		public static float CrossXY(this Vector3 vector, Vector3 other)
		{
			return vector.x * other.y - other.x * vector.y;
		}

		/// <summary>
		/// Returns the cross product of two vectors (which in 2D is the determinant), 
		/// for the <c>x</c> and <c>z</c> components.
		/// </summary>
		/// <remarks>
		/// This operation is anticommutative, i.e. `a.Cross(b) == b.Cross(-a)`.
		/// 
		/// See https://en.wikipedia.org/wiki/Cross_product
		/// </remarks>
		[Obsolete("Use 'DeterminantXZ' instead.")]
		public static float CrossXZ(this Vector3 vector, Vector3 other)
		{
			return vector.x * other.z - other.x * vector.z;
		}

		/// <summary>
		/// Returns the cross product of two vectors (which in 2D is the determinant), 
		/// for the <c>y</c> and <c>z</c> components.
		/// </summary>
		/// <remarks>
		/// This operation is anticommutative, i.e. `a.Cross(b) == b.Cross(-a)`.
		/// 
		/// See https://en.wikipedia.org/wiki/Cross_product
		/// </remarks>
		[Obsolete("Use 'DeterminantYZ' instead.")]
		public static float CrossYZ(this Vector3 vector, Vector3 other)
		{
			return vector.y * other.z - other.y * vector.z;
		}
	}
}