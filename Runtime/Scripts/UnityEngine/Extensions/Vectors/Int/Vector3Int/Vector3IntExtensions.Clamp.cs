namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3IntExtensions
	{
		public static Vector3Int ClampX(this Vector3Int vector, int min, int max)
		{
			return new Vector3Int(vector.x.Clamp(min, max), vector.y, vector.z);
		}

		public static Vector3Int ClampXY(this Vector3Int vector, Vector3Int min, Vector3Int max)
		{
			return new Vector3Int(vector.x.Clamp(min.x, max.x), vector.y.Clamp(min.y, max.y), vector.z);
		}

		public static Vector3Int ClampXYZ(this Vector3Int vector, Vector3Int min, Vector3Int max)
		{
			return new Vector3Int(vector.x.Clamp(min.x, max.x), vector.y.Clamp(min.y, max.y), vector.z.Clamp(min.z, max.z));
		}

		public static Vector3Int ClampXZ(this Vector3Int vector, Vector3Int min, Vector3Int max)
		{
			return new Vector3Int(vector.x.Clamp(min.x, max.x), vector.y, vector.z.Clamp(min.z, max.z));
		}

		public static Vector3Int ClampY(this Vector3Int vector, int min, int max)
		{
			return new Vector3Int(vector.x, vector.y.Clamp(min, max), vector.z);
		}

		public static Vector3Int ClampYZ(this Vector3Int vector, Vector3Int min, Vector3Int max)
		{
			return new Vector3Int(vector.x, vector.y.Clamp(min.y, max.y), vector.z.Clamp(min.z, max.z));
		}

		public static Vector3Int ClampZ(this Vector3Int vector, int min, int max)
		{
			return new Vector3Int(vector.x, vector.y, vector.z.Clamp(min, max));
		}
	}
}