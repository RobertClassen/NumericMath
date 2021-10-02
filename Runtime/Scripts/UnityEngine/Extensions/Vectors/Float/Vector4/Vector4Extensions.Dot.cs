namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector4Extensions
	{
		/// <summary>
		/// Returns the sum of the component-wise multiplications of both vectors.
		/// </summary>
		/// <remarks>
		/// For normalized vectors Dot returns 1 if they point in exactly the same direction, 
		/// -1 if they point in completely opposite directions and zero if the vectors are perpendicular.
		/// 
		/// See https://docs.unity3d.com/ScriptReference/Vector4.Dot.html  
		/// See https://en.wikipedia.org/wiki/Dot_product
		/// </remarks>
		public static float Dot(this Vector4 vector, Vector4 other)
		{
			return vector.x * other.x + vector.y * other.y + vector.z * other.z + vector.w * other.w;
		}
	}
}