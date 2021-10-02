namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Returns a vector that is made from the smallest components of two vectors.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector3.Min.html
		/// </remarks>
		/// <seealso cref="Max"/>
		public static Vector3 Min(this Vector3 vector, Vector3 other)
		{
			return new Vector3(vector.x.Min(other.x), vector.y.Min(other.y), vector.z.Min(other.z));
		}
	}
}