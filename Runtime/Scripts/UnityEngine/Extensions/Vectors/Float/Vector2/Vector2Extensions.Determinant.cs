namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		/// <summary>
		/// Returns the signed magnitude of the area of the parallelogram described by the vectors.
		/// </summary>
		/// <remarks>
		/// This operation is anticommutative, i.e. `a.Cross(b) == b.Cross(-a)`.
		/// 
		/// See https://en.wikipedia.org/wiki/Determinant
		/// </remarks>
		public static float Determinant(this Vector2 vector, Vector2 other)
		{
			return vector.x * other.y - other.x * vector.y;
		}
	}
}