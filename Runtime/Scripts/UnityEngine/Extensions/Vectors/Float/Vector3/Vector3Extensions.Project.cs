namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Projects a vector onto another vector.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector3.Project.html
		/// </remarks>
		public static Vector3 Project(this Vector3 vector, Vector3 onNormal)
		{
			return Vector3.Project(vector, onNormal);
		}

		/// <summary>
		/// Projects a vector onto a plane defined by a normal orthogonal to the plane.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector3.ProjectOnPlane.html
		/// </remarks>
		public static Vector3 ProjectOnPlane(this Vector3 vector, Vector3 planeNormal)
		{
			return Vector3.ProjectOnPlane(vector, planeNormal);
		}
	}
}