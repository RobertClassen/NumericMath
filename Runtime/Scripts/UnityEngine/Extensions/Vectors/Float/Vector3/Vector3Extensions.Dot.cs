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
		public static float Dot(this Vector3 vector, Vector3 other)
		{
			return Vector3.Dot(vector, other);
		}

		public static float DotXY(this Vector3 vector, Vector3 other)
		{
			return vector.x * other.x + vector.y + other.y;
		}

		public static float DotXZ(this Vector3 vector, Vector3 other)
		{
			return vector.x * other.x + vector.z + other.z;
		}

		public static float DotYZ(this Vector3 vector, Vector3 other)
		{
			return vector.y * other.y + vector.z + other.z;
		}
		#endregion
	}
}