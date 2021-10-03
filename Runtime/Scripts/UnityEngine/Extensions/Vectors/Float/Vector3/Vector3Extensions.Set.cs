namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		public static Vector3 SetMagnitude(this Vector3 vector, float magnitude)
		{
			return vector.normalized * magnitude;
		}

		public static Vector3 SetX(this Vector3 vector, float x)
		{
			return new Vector3(x, vector.y, vector.z);
		}

		public static Vector3 SetXY(this Vector3 vector, float x, float y)
		{
			return new Vector3(x, y, vector.z);
		}

		public static Vector3 SetXYZ(this Vector3 vector, float x, float y, float z)
		{
			return new Vector3(x, y, z);
		}

		public static Vector3 SetXZ(this Vector3 vector, float x, float z)
		{
			return new Vector3(x, vector.y, z);
		}

		public static Vector3 SetY(this Vector3 vector, float y)
		{
			return new Vector3(vector.x, y, vector.z);
		}

		public static Vector3 SetYZ(this Vector3 vector, float y, float z)
		{
			return new Vector3(vector.x, y, z);
		}

		public static Vector3 SetZ(this Vector3 vector, float z)
		{
			return new Vector3(vector.x, vector.y, z);
		}
	}
}