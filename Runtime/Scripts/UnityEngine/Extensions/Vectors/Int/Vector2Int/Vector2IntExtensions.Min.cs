namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2IntExtensions
	{
		/// <summary>
		/// Returns a vector that is made from the smallest components of two vectors.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector2Int.Min.html
		/// </remarks>
		/// <seealso cref="Max"/>
		public static Vector2Int Min(this Vector2Int vector, Vector2Int other)
		{
			return new Vector2Int(vector.x.Min(other.x), vector.y.Min(other.y));
		}
	}
}