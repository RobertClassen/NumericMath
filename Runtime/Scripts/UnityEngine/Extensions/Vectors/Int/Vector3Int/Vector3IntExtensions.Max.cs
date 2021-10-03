namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3IntExtensions
	{
		/// <summary>
		/// Returns a vector that is made from the largest components of two vectors.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector3Int.Max.html
		/// </remarks>
		/// <seealso cref="Min"/>
		public static Vector3Int Max(this Vector3Int vector, Vector3Int other)
		{
			return new Vector3Int(vector.x.Max(other.x), vector.y.Max(other.y), vector.z.Max(other.z));
		}
	}
}