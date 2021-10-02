namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector4Extensions
	{
		/// <summary>
		/// Linearly interpolates between both vectors by <c>t</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector4.LerpUnclamped.html  
		/// See https://docs.unity3d.com/ScriptReference/Vector4.Lerp.html
		/// </remarks>
		public static Vector4 Lerp(this Vector4 vector, Vector4 other, float t = Float.OneHalf, 
			bool isClamped = Core.Numeric.IsLerpClampedDefault)
		{
			return new Vector4(
				t.Lerp(vector.x, other.x, isClamped), 
				t.Lerp(vector.y, other.y, isClamped), 
				t.Lerp(vector.z, other.z, isClamped), 
				t.Lerp(vector.w, other.w, isClamped));
		}
	}
}