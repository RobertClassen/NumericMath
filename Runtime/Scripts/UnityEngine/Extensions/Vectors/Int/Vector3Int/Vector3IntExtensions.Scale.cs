namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3IntExtensions
	{
		public static Vector3Int ScaleX(this Vector3Int vector, int x)
		{
			return new Vector3Int(vector.x * x, vector.y, vector.z);
		}

		public static Vector3Int ScaleXY(this Vector3Int vector, Vector3Int factor)
		{
			return new Vector3Int(vector.x * factor.x, vector.y * factor.y, vector.z);
		}

		public static Vector3Int ScaleXYZ(this Vector3Int vector, Vector3Int factor)
		{
			return new Vector3Int(vector.x * factor.x, vector.y * factor.y, vector.z * factor.z);
		}

		public static Vector3Int ScaleXZ(this Vector3Int vector, Vector3Int factor)
		{
			return new Vector3Int(vector.x * factor.x, vector.y, vector.z * factor.z);
		}

		public static Vector3Int ScaleY(this Vector3Int vector, int y)
		{
			return new Vector3Int(vector.x, vector.y * y, vector.z);
		}

		public static Vector3Int ScaleYZ(this Vector3Int vector, Vector3Int factor)
		{
			return new Vector3Int(vector.x, vector.y * factor.y, vector.z * factor.z);
		}

		public static Vector3Int ScaleZ(this Vector3Int vector, int z)
		{
			return new Vector3Int(vector.x, vector.y, vector.z * z);
		}
	}
}