namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Returns the distance between both vectors.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector3.Distance.html
		/// </remarks>
		public static float Distance(this Vector3 vector, Vector3 other)
		{
			float x = vector.x - other.x;
			float y = vector.y - other.y;
			float z = vector.z - other.z;
			return (float)Math.Sqrt((double)(x * x + y * y + z * z));
		}
	}
}