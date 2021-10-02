namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Moves the point current towards the <c>target</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector3.MoveTowards.html
		/// </remarks>
		public static Vector3 MoveTowards(this Vector3 point, Vector3 target, float maxDistanceDelta)
		{
			return Vector3.MoveTowards(point, target, maxDistanceDelta);
		}
	}
}