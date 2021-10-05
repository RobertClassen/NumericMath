namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
	using UnityEngine;

	public static partial class QuaternionExtensions
	{
		/// <summary>
		/// Spherically interpolates between both Quaternions by <c>t</c> and normalizes the result afterwards.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Quaternion.SlerpUnclamped.html  
		/// See https://docs.unity3d.com/ScriptReference/Quaternion.Slerp.html
		/// </remarks>
		/// <seealso cref="Lerp"/>
		public static Quaternion Slerp(this Quaternion quaternion, Quaternion other, float t, 
			bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return isClamped ? Quaternion.Slerp(quaternion, other, t) : Quaternion.SlerpUnclamped(quaternion, other, t);
		}
	}
}