namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Returns a vector that is made from the largest components of two vectors.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector3.Max.html
		/// </remarks>
		/// <seealso cref="Min"/>
		public static Vector3 Max(this Vector3 vector, Vector3 other)
		{
			return new Vector3(vector.x.Max(other.x), vector.y.Max(other.y), vector.z.Max(other.z));
		}
	}
}