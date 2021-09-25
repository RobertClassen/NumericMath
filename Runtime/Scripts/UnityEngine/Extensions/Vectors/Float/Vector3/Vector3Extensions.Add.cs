namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using Random = UnityEngine.Random;

	public static partial class Vector3Extensions
	{
		public static Vector3 AddRandom(this Vector3 vector, Vector3 min, Vector3 max)
		{
			return new Vector3(vector.x + Random.Range(min.x, max.x), vector.y + Random.Range(min.y, max.y), vector.z + Random.Range(min.x, max.x));
		}

		public static Vector3 AddX(this Vector3 vector, float x)
		{
			return new Vector3(vector.x + x, vector.y, vector.z);
		}

		public static Vector3 AddY(this Vector3 vector, float y)
		{
			return new Vector3(vector.x, vector.y + y, vector.z);
		}

		public static Vector3 AddZ(this Vector3 vector, float z)
		{
			return new Vector3(vector.x, vector.y, vector.z + z);
		}
	}
}