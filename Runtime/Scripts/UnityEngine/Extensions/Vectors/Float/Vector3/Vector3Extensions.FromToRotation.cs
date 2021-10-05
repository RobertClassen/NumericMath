namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Creates a <c>Quaternion</c> which rotates from <c>fromDirection</c> to <c>toDirection</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Quaternion.FromToRotation.html
		/// </remarks>
		public static Quaternion FromToRotation(this Vector3 fromDirection, Vector3 toDirection)
		{
			return Quaternion.FromToRotation(fromDirection, toDirection);
		}
	}
}