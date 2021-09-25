namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		/// <summary>
		/// Returns the cross product of two vectors (which in 2D is the determinant).
		/// </summary>
		/// <remarks>
		/// This operation is anticommutative, i.e. `a.Cross(b) == b.Cross(-a)`.
		/// 
		/// See https://en.wikipedia.org/wiki/Cross_product
		/// </remarks>
		[Obsolete("Use 'Determinant' instead.")]
		public static float Cross(this Vector2 vector, Vector2 other)
		{
			return vector.x * other.y - other.x * vector.y;
		}
	}
}