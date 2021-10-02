namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		[Obsolete("Use 'normalized' directly instead.")]
		public static Vector3 NormalizeMagnitude(this Vector3 vector)
		{
			return vector.normalized;
		}

		/// <summary>
		/// Makes vectors normalized and orthogonal to each other.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector3.OrthoNormalize.html
		/// </remarks>
		public static Vector3 OrthoNormalize(this Vector3 normal, ref Vector3 tangent)
		{
			Vector3.OrthoNormalize(ref normal, ref tangent);
			return normal;
		}

		/// <summary>
		/// Makes vectors normalized and orthogonal to each other.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector3.OrthoNormalize.html
		/// </remarks>
		public static Vector3 OrthoNormalize(this Vector3 normal, ref Vector3 tangent, ref Vector3 binormal)
		{
			Vector3.OrthoNormalize(ref normal, ref tangent, ref binormal);
			return normal;
		}
	}
}