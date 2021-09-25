namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		public static Vector3 Clamp01(this Vector3 vector, bool isEnabled = Core.Numeric.IsClampEnabledDefault)
		{
			return isEnabled ? vector.ClampXYZ(Vector3.zero, Vector3.one) : vector;
		}

		public static Vector3 ClampX(this Vector3 vector, float min, float max)
		{
			return new Vector3(vector.x.Clamp(min, max), vector.y, vector.z);
		}

		public static Vector3 ClampXY(this Vector3 vector, Vector3 min, Vector3 max)
		{
			return new Vector3(vector.x.Clamp(min.x, max.x), vector.y.Clamp(min.y, max.y), vector.z);
		}

		public static Vector3 ClampXY(this Vector3 vector, Rect rect)
		{
			return vector.ClampXY(rect.min, rect.max);
		}

		public static Vector3 ClampXYZ(this Vector3 vector, Vector3 min, Vector3 max)
		{
			return new Vector3(vector.x.Clamp(min.x, max.x), vector.y.Clamp(min.y, max.y), vector.z.Clamp(min.z, max.z));
		}

		public static Vector3 ClampXZ(this Vector3 vector, Vector3 min, Vector3 max)
		{
			return new Vector3(vector.x.Clamp(min.x, max.x), vector.y, vector.z.Clamp(min.z, max.z));
		}

		public static Vector3 ClampXZ(this Vector3 vector, Rect rect)
		{
			return vector.ClampXZ(rect.min, rect.max);
		}

		public static Vector3 ClampY(this Vector3 vector, float min, float max)
		{
			return new Vector3(vector.x, vector.y.Clamp(min, max), vector.z);
		}

		public static Vector3 ClampYZ(this Vector3 vector, Vector3 min, Vector3 max)
		{
			return new Vector3(vector.x, vector.y.Clamp(min.y, max.y), vector.z.Clamp(min.z, max.z));
		}

		public static Vector3 ClampYZ(this Vector3 vector, Rect rect)
		{
			return vector.ClampYZ(rect.min, rect.max);
		}

		public static Vector3 ClampZ(this Vector3 vector, float min, float max)
		{
			return new Vector3(vector.x, vector.y, vector.z.Clamp(min, max));
		}
	}
}