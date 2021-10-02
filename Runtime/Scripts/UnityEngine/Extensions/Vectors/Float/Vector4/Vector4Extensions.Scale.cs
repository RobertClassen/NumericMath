namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector4Extensions
	{
		/// <summary>
		/// Multiplies two vectors component-wise.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector4.Scale.html
		/// </remarks>
		public static Vector4 ScaleXYZW(this Vector4 vector, Vector4 factor)
		{
			return new Vector4(vector.x * factor.x, vector.y * factor.y, vector.z * factor.z, vector.w * factor.w);
		}
	}
}