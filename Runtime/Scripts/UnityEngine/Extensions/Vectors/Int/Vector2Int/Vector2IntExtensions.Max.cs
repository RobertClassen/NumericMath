namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2IntExtensions
	{
		/// <summary>
		/// Returns a vector that is made from the largest components of two vectors.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector2Int.Max.html
		/// </remarks>
		/// <seealso cref="Min"/>
		public static Vector2Int Max(this Vector2Int vector, Vector2Int other)
		{
			return new Vector2Int(vector.x.Max(other.x), vector.y.Max(other.y));
		}
	}
}