namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Creates a <c>Quaternion</c> which rotates 
		/// z degrees around the z axis, 
		/// x degrees around the x axis, and 
		/// y degrees around the y axis.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Quaternion.Euler.html
		/// </remarks>
		public static Quaternion Euler(this Vector3 euler)
		{
			return Quaternion.Euler(euler);
		}
	}
}