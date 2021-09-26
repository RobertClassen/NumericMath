namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
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
	}
}