namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector4Extensions
	{
		/// <summary>
		/// Returns a vector that is made from the largest components of two vectors.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector4.Max.html
		/// </remarks>
		/// <seealso cref="Min"/>
		public static Vector4 Max(this Vector4 vector, Vector4 other)
		{
			return new Vector4(vector.x.Max(other.x), vector.y.Max(other.y), vector.z.Max(other.z), vector.w.Max(other.w));
		}
	}
}