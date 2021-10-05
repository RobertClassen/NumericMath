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
		/// Interpolates between both Quaternions by <c>t</c> and normalizes the result afterwards.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Quaternion.LerpUnclamped.html  
		/// See https://docs.unity3d.com/ScriptReference/Quaternion.Lerp.html
		/// </remarks>
		/// <seealso cref="Slerp"/>
		public static Quaternion Lerp(this Quaternion quaternion, Quaternion other, float t, 
			bool isClamped = Numeric.IsLerpClampedDefault)
		{
			return isClamped ? Quaternion.Lerp(quaternion, other, t) : Quaternion.LerpUnclamped(quaternion, other, t);
		}
	}
}