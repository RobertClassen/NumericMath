namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3IntExtensions
	{
		public static Vector3Int SetX(this Vector3Int vector, int x)
		{
			return new Vector3Int(x, vector.y, vector.z);
		}

		public static Vector3Int SetXY(this Vector3Int vector, int x, int y)
		{
			return new Vector3Int(x, y, vector.z);
		}

		public static Vector3Int SetXYZ(this Vector3Int vector, int x, int y, int z)
		{
			return new Vector3Int(x, y, z);
		}

		public static Vector3Int SetXZ(this Vector3Int vector, int x, int z)
		{
			return new Vector3Int(x, vector.y, z);
		}

		public static Vector3Int SetY(this Vector3Int vector, int y)
		{
			return new Vector3Int(vector.x, y, vector.z);
		}

		public static Vector3Int SetYZ(this Vector3Int vector, int y, int z)
		{
			return new Vector3Int(vector.x, y, z);
		}

		public static Vector3Int SetZ(this Vector3Int vector, int z)
		{
			return new Vector3Int(vector.x, vector.y, z);
		}
	}
}