namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class QuaternionExtensions
	{
		/// <summary>
		/// Rotates the <c>Quaternion</c> towards the other one.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Quaternion.RotateTowards.html
		/// </remarks>
		public static Quaternion RotateTowards(this Quaternion from, Quaternion to, float maxDegreesDelta)
		{
			return Quaternion.RotateTowards(from, to, maxDegreesDelta);
		}
	}
}