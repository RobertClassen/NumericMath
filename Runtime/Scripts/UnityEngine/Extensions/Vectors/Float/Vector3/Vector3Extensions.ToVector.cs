namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		public static Vector2Int ToVector2IntXY(this Vector3 vector)
		{
			return new Vector2Int((int)vector.x, (int)vector.y);
		}

		public static Vector2Int ToVector2IntXZ(this Vector3 vector)
		{
			return new Vector2Int((int)vector.x, (int)vector.z);
		}

		public static Vector2Int ToVector2IntYZ(this Vector3 vector)
		{
			return new Vector2Int((int)vector.y, (int)vector.z);
		}

		public static Vector2 ToVector2XY(this Vector3 vector)
		{
			return new Vector2(vector.x, vector.y);
		}

		public static Vector2 ToVector2XZ(this Vector3 vector)
		{
			return new Vector2(vector.x, vector.z);
		}

		public static Vector2 ToVector2YZ(this Vector3 vector)
		{
			return new Vector2(vector.y, vector.z);
		}

		public static Vector3Int ToVector3Int(this Vector3 vector)
		{
			return new Vector3Int((int)vector.x, (int)vector.y, (int)vector.z);
		}
	}
}