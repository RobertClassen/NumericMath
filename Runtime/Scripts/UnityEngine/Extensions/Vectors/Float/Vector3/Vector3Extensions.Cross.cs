namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using Random = UnityEngine.Random;

	public static partial class Vector3Extensions
	{
		#region Fields
		
		#endregion

		#region Properties
		
		#endregion

		#region Constructors
		
		#endregion

		#region Methods
		public static Vector3 Cross(this Vector3 vector, Vector3 other)
		{
			return Vector3.Cross(vector, other);
		}

		public static float CrossXY(this Vector3 vector, Vector3 other)
		{
			return vector.x * other.y - other.x * vector.y;
		}

		public static float CrossXZ(this Vector3 vector, Vector3 other)
		{
			return vector.x * other.z - other.x * vector.z;
		}

		public static float CrossYZ(this Vector3 vector, Vector3 other)
		{
			return vector.y * other.z - other.y * vector.z;
		}
		#endregion
	}
}