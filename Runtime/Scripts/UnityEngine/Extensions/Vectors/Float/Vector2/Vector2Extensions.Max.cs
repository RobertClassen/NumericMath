namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		/// <summary>
		/// Returns a vector that is made from the largest components of two vectors.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector2.Max.html
		/// </remarks>
		/// <seealso cref="Min"/>
		public static Vector2 Max(this Vector2 vector, Vector2 other)
		{
			return new Vector2(vector.x.Max(other.x), vector.y.Max(other.y));
		}
	}
}