namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector4Extensions
	{
		/// <summary>
		/// Returns the distance between both vectors.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector4.Distance.html
		/// </remarks>
		public static float Distance(this Vector4 vector, Vector4 other)
		{
			return (float)Math.Sqrt((double)vector.Dot(other));
		}
	}
}