namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Linearly interpolates between both vectors by <c>t</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector3.LerpUnclamped.html  
		/// See https://docs.unity3d.com/ScriptReference/Vector3.Lerp.html
		/// </remarks>
		public static Vector3 Lerp(this Vector3 vector, Vector3 other, float t = Float.OneHalf, 
			bool isClamped = Core.Numeric.IsLerpClampedDefault)
		{
			return new Vector3(
				t.Lerp(vector.x, other.x, isClamped), 
				t.Lerp(vector.y, other.y, isClamped), 
				t.Lerp(vector.z, other.z, isClamped));
		}
	}
}