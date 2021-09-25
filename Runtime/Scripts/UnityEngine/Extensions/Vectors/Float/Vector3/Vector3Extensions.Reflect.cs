namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		/// <summary>
		/// Reflects the vector off the plane defined by the <c>normal</c>.
		/// </summary>
		/// <remarks>
		/// See https://docs.unity3d.com/ScriptReference/Vector3.Reflect.html
		/// </remarks>
		public static Vector3 Reflect(this Vector3 vector, Vector3 normal)
		{
			return Vector3.Reflect(vector, normal);
		}

		/// <summary>
		/// Reflects the vector horizontally.
		/// </summary>
		public static Vector3 ReflectX(this Vector3 vector)
		{
			return new Vector3(-vector.x, vector.y, vector.z);
		}

		/// <summary>
		/// Reflects the vector vertically.
		/// </summary>
		public static Vector3 ReflectY(this Vector3 vector)
		{
			return new Vector3(vector.x, -vector.y, vector.z);
		}

		/// <summary>
		/// Reflects the vector both horizontally and vertically.
		/// </summary>
		public static Vector3 ReflectXY(this Vector3 vector)
		{
			return new Vector3(-vector.x, -vector.y, vector.z);
		}

		/// <summary>
		/// Reflects the vector horizontally, vertically, and by depth.
		/// </summary>
		public static Vector3 ReflectXYZ(this Vector3 vector)
		{
			return new Vector3(-vector.x, -vector.y, -vector.z);
		}

		/// <summary>
		/// Reflects the vector both horizontally and by depth.
		/// </summary>
		public static Vector3 ReflectXZ(this Vector3 vector)
		{
			return new Vector3(-vector.x, vector.y, -vector.z);
		}

		/// <summary>
		/// Reflects the vector both vertically and by depth.
		/// </summary>
		public static Vector3 ReflectYZ(this Vector3 vector)
		{
			return new Vector3(vector.x, -vector.y, -vector.z);
		}

		/// <summary>
		/// Reflects the vector by depth.
		/// </summary>
		public static Vector3 ReflectZ(this Vector3 vector)
		{
			return new Vector3(vector.x, vector.y, -vector.z);
		}
	}
}