namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector2Extensions
	{
		/// <summary>
		/// Moves the point current towards the <c>target</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector2.MoveTowards.html
		/// </remarks>
		public static Vector2 MoveTowards(this Vector2 point, Vector2 target, float maxDistanceDelta)
		{
			return Vector2.MoveTowards(point, target, maxDistanceDelta);
		}
	}
}