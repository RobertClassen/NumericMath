namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector4Extensions
	{
		/// <summary>
		/// Moves the point current towards the <c>target</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector4.MoveTowards.html
		/// </remarks>
		public static Vector4 MoveTowards(this Vector4 point, Vector4 target, float maxDistanceDelta)
		{
			return Vector4.MoveTowards(point, target, maxDistanceDelta);
		}
	}
}