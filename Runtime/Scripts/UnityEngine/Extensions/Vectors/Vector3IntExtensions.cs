namespace WellDefined
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static class Vector3IntExtensions
	{
		#region Fields
		
		#endregion

		#region Properties
		
		#endregion

		#region Constructors
		
		#endregion

		#region Methods
		public static Vector3Int Abs(this Vector3Int vector)
		{
			return new Vector3Int(vector.x.Abs(), vector.y.Abs(), vector.z.Abs());
		}

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

		public static Vector3Int DivideBy(this Vector3Int dividend, Vector3Int divisor)
		{
			return new Vector3Int(dividend.x / divisor.x, dividend.y / divisor.y, dividend.z / divisor.z);
		}

		public static Vector3Int Modulo(this Vector3Int dividend, Vector3Int divisor)
		{
			return new Vector3Int(dividend.x.Modulo(divisor.x), dividend.y.Modulo(divisor.y), dividend.z.Modulo(divisor.z));
		}

		public static Vector3Int Remainder(this Vector3Int dividend, Vector3Int divisor)
		{
			return new Vector3Int(dividend.x % divisor.x, dividend.y % divisor.y, dividend.z % divisor.z);
		}

		public static Vector3Int Sign(this Vector3Int vector)
		{
			return new Vector3Int(vector.x.Sign(), vector.y.Sign(), vector.z.Sign());
		}
		#endregion
	}
}