namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2IntExtensions
	{
		/// <summary>
		/// Returns the distance between both vectors.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector2Int.Distance.html
		/// </remarks>
		public static float Distance(this Vector2Int vector, Vector2Int other)
		{
			float x = vector.x - other.x;
			float y = vector.y - other.y;
			return (float)Math.Sqrt((double)(x * x + y * y));
		}
	}
}