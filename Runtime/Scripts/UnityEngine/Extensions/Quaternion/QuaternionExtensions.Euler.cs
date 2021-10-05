namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class QuaternionExtensions
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
		[Obsolete("Use 'euler.Euler' instead.")]
		public static Quaternion Euler(this Quaternion quaternion, float x, float y, float z)
		{
			return Quaternion.Euler(x, y, z);
		}

		/// <summary>
		/// Creates a <c>Quaternion</c> which rotates 
		/// z degrees around the z axis, 
		/// x degrees around the x axis, and 
		/// y degrees around the y axis.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Quaternion.Euler.html
		/// </remarks>
		[Obsolete("Use 'euler.Euler' instead.")]
		public static Quaternion Euler(this Quaternion quaternion, Vector3 euler)
		{
			return Quaternion.Euler(euler);
		}
	}
}