namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		public static Vector3 ScaleX(this Vector3 vector, float x)
		{
			return new Vector3(vector.x * x, vector.y, vector.z);
		}

		public static Vector3 ScaleXY(this Vector3 vector, Vector3 factor)
		{
			return new Vector3(vector.x * factor.x, vector.y * factor.y, vector.z);
		}

		public static Vector3 ScaleXYZ(this Vector3 vector, Vector3 factor)
		{
			return new Vector3(vector.x * factor.x, vector.y * factor.y, vector.z * factor.z);
		}

		public static Vector3 ScaleXZ(this Vector3 vector, Vector3 factor)
		{
			return new Vector3(vector.x * factor.x, vector.y, vector.z * factor.z);
		}

		public static Vector3 ScaleY(this Vector3 vector, float y)
		{
			return new Vector3(vector.x, vector.y * y, vector.z);
		}

		public static Vector3 ScaleYZ(this Vector3 vector, Vector3 factor)
		{
			return new Vector3(vector.x, vector.y * factor.y, vector.z * factor.z);
		}

		public static Vector3 ScaleZ(this Vector3 vector, float z)
		{
			return new Vector3(vector.x, vector.y, vector.z * z);
		}
	}
}