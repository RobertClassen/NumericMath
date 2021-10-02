namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Returns the sum of the component-wise multiplications of both vectors.
		/// </summary>
		/// <remarks>
		/// For normalized vectors Dot returns 1 if they point in exactly the same direction, 
		/// -1 if they point in completely opposite directions and zero if the vectors are perpendicular.
		/// 
		/// See https://docs.unity3d.com/ScriptReference/Vector3.Dot.html  
		/// See https://en.wikipedia.org/wiki/Dot_product
		/// </remarks>
		public static float Dot(this Vector3 vector, Vector3 other)
		{
			return Vector3.Dot(vector, other);
		}

		/// <summary>
		/// Returns the sum of the component-wise multiplications of both vectors, 
		/// for the <c>x</c> and <c>y</c> components.
		/// </summary>
		/// <remarks>
		/// For normalized vectors Dot returns 1 if they point in exactly the same direction, 
		/// -1 if they point in completely opposite directions and zero if the vectors are perpendicular.
		/// 
		/// See https://docs.unity3d.com/ScriptReference/Vector2.Dot.html  
		/// See https://en.wikipedia.org/wiki/Dot_product
		/// </remarks>
		public static float DotXY(this Vector3 vector, Vector3 other)
		{
			return vector.x * other.x + vector.y * other.y;
		}

		/// <summary>
		/// Returns the sum of the component-wise multiplications of both vectors, 
		/// for the <c>x</c> and <c>z</c> components.
		/// </summary>
		/// <remarks>
		/// For normalized vectors Dot returns 1 if they point in exactly the same direction, 
		/// -1 if they point in completely opposite directions and zero if the vectors are perpendicular.
		/// 
		/// See https://docs.unity3d.com/ScriptReference/Vector2.Dot.html  
		/// See https://en.wikipedia.org/wiki/Dot_product
		/// </remarks>
		public static float DotXZ(this Vector3 vector, Vector3 other)
		{
			return vector.x * other.x + vector.z * other.z;
		}

		/// <summary>
		/// Returns the sum of the component-wise multiplications of both vectors, 
		/// for the <c>y</c> and <c>z</c> components.
		/// </summary>
		/// <remarks>
		/// For normalized vectors Dot returns 1 if they point in exactly the same direction, 
		/// -1 if they point in completely opposite directions and zero if the vectors are perpendicular.
		/// 
		/// See https://docs.unity3d.com/ScriptReference/Vector2.Dot.html  
		/// See https://en.wikipedia.org/wiki/Dot_product
		/// </remarks>
		public static float DotYZ(this Vector3 vector, Vector3 other)
		{
			return vector.y * other.y + vector.z * other.z;
		}
	}
}