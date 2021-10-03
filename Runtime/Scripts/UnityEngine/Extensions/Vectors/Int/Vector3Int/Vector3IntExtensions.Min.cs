namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3IntExtensions
	{
		/// <summary>
		/// Returns a vector that is made from the smallest components of two vectors.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector3Int.Min.html
		/// </remarks>
		/// <seealso cref="Max"/>
		public static Vector3Int Min(this Vector3Int vector, Vector3Int other)
		{
			return new Vector3Int(vector.x.Min(other.x), vector.y.Min(other.y), vector.z.Min(other.z));
		}
	}
}