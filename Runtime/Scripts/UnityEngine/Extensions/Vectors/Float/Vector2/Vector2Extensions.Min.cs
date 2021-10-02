namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		/// <summary>
		/// Returns a vector that is made from the smallest components of two vectors.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector2.Min.html
		/// </remarks>
		/// <seealso cref="Max"/>
		public static Vector2 Min(this Vector2 vector, Vector2 other)
		{
			return new Vector2(vector.x.Min(other.x), vector.y.Min(other.y));
		}
	}
}