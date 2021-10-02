namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector4Extensions
	{
		/// <summary>
		/// Returns a vector that is made from the smallest components of two vectors.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector4.Min.html
		/// </remarks>
		/// <seealso cref="Max"/>
		public static Vector4 Min(this Vector4 vector, Vector4 other)
		{
			return new Vector4(vector.x.Min(other.x), vector.y.Min(other.y), vector.z.Min(other.z), vector.w.Min(other.w));
		}
	}
}