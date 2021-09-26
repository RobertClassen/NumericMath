namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		/// <summary>
		/// Linearly interpolates between both vectors by <c>t</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector2.LerpUnclamped.html  
		/// See https://docs.unity3d.com/ScriptReference/Vector2.Lerp.html
		/// </remarks>
		public static Vector2 Lerp(this Vector2 vector, Vector2 other, float t = Float.OneHalf, 
			bool isClamped = Core.Numeric.IsLerpClampedDefault)
		{
			return new Vector2(
				t.Lerp(vector.x, other.x, isClamped), 
				t.Lerp(vector.y, other.y, isClamped));
		}
	}
}