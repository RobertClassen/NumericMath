namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class QuaternionExtensions
	{
		/// <summary>
		/// Creates a <c>Quaternion</c> with the specified <c>forward</c> and <c>upward</c> directions.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Quaternion.LookRotation.html
		/// </remarks>
		[Obsolete("Use 'forward.LookRotation' instead.")]
		public static Quaternion LookRotation(this Quaternion quaternion, Vector3 forward)
		{
			return Quaternion.LookRotation(forward, Vector3.up);
		}

		/// <summary>
		/// Creates a <c>Quaternion</c> with the specified <c>forward</c> and <c>upward</c> directions.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Quaternion.LookRotation.html
		/// </remarks>
		[Obsolete("Use 'forward.LookRotation' instead.")]
		public static Quaternion LookRotation(this Quaternion quaternion, Vector3 forward, Vector3 upward)
		{
			return Quaternion.LookRotation(forward, upward);
		}
	}
}