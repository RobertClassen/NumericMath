namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class RectIntExtensions
	{
		public static void DrawDebugLines(this RectInt rect, Color color, float depth = Float.Zero)
		{
			#if UNITY_EDITOR
			float xMin = rect.xMin;
			float xMax = rect.xMax;
			float yMin = rect.yMin;
			float yMax = rect.yMax;
			Vector3 topLeft = new Vector3(xMin, yMax, depth);
			Vector3 topRight = new Vector3(xMax, yMax, depth);
			Vector3 bottomLeft = new Vector3(xMin, yMin, depth);
			Vector3 bottomRight = new Vector3(xMax, yMin, depth);
			Debug.DrawLine(topLeft, topRight, color);
			Debug.DrawLine(bottomLeft, bottomRight, color);
			Debug.DrawLine(topLeft, bottomLeft, color);
			Debug.DrawLine(topRight, bottomRight, color);
			#endif
		}

		public static void DrawGizmoLines(this RectInt rect, Color color, float depth = Float.Zero)
		{
			#if UNITY_EDITOR
			float xMin = rect.xMin;
			float xMax = rect.xMax;
			float yMin = rect.yMin;
			float yMax = rect.yMax;
			Vector3 topLeft = new Vector3(xMin, yMax, depth);
			Vector3 topRight = new Vector3(xMax, yMax, depth);
			Vector3 bottomLeft = new Vector3(xMin, yMin, depth);
			Vector3 bottomRight = new Vector3(xMax, yMin, depth);
			Gizmos.color = color;
			Gizmos.DrawLine(topLeft, topRight);
			Gizmos.DrawLine(bottomLeft, bottomRight);
			Gizmos.DrawLine(topLeft, bottomLeft);
			Gizmos.DrawLine(topRight, bottomRight);
			#endif
		}
	}
}