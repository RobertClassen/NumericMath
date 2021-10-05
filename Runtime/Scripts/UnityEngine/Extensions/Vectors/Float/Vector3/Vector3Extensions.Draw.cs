namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class Vector3Extensions
	{
		public static void DrawDebugLine(this Vector3 vector, Color color, Vector3 origin = default(Vector3), 
			float duration = Float.Zero, bool depthTest = true)
		{
			Debug.DrawLine(origin, vector, color, duration, depthTest);
		}

		public static void DrawDebugRay(this Vector3 vector, Color color, Vector3 origin = default(Vector3), 
			float duration = Float.Zero, bool depthTest = true)
		{
			Debug.DrawRay(origin, vector, color, duration, depthTest);
		}

		public static void DrawGizmoLine(this Vector3 vector, Color color, Vector3 origin = default(Vector3))
		{
			Gizmos.color = color;
			Gizmos.DrawLine(origin, vector);
		}

		public static void DrawGizmoRay(this Vector3 vector, Color color, Vector3 origin = default(Vector3))
		{
			Gizmos.color = color;
			Gizmos.DrawRay(origin, vector);
		}
	}
}