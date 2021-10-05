namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class RayExtensions
	{
		public static void DrawDebugRay(this Ray ray, Color color, float duration = Float.Zero, bool depthTest = true)
		{
			Debug.DrawRay(ray.origin, ray.direction, color, duration, depthTest);
		}

		public static void DrawGizmoRay(this Ray ray, Color color)
		{
			Gizmos.color = color;
			Gizmos.DrawRay(ray);
		}
	}
}