namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3IntExtensions
	{
		/// <summary>
		/// Returns the distance between both vectors.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector3Int.Distance.html
		/// </remarks>
		public static float Distance(this Vector3Int vector, Vector3Int other)
		{
			float x = vector.x - other.x;
			float y = vector.y - other.y;
			float z = vector.z - other.z;
			return (float)Math.Sqrt((double)(x * x + y * y + z * z));
		}
	}
}