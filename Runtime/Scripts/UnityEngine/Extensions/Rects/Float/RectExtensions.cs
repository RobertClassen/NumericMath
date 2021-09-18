namespace WellDefinedTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class RectExtensions
	{
		#region Constants
		private const bool IsEnabledDefault = true;
		private const float IndentationWidth = 15f;
		private const float ExpansionFactor = 2f;
		#endregion

		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
		public static void DrawDebugLines(this Rect rect, Color color, float depth = Float.Zero)
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

		public static void DrawGizmoLines(this Rect rect, Color color, float depth = Float.Zero)
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

		public static Rect Expand(this Rect rect, float margin, bool isEnabled = IsEnabledDefault)
		{
			return isEnabled ? rect.Expand(margin, margin, margin, margin) : rect;
		}

		public static Rect Expand(this Rect rect, float x, float y, bool isEnabled = IsEnabledDefault)
		{
			return isEnabled ? rect.Expand(x, x, y, y) : rect;
		}

		public static Rect Expand(this Rect rect, float left, float right, float down, float up, 
			bool isEnabled = IsEnabledDefault)
		{
			return isEnabled ? new Rect(rect.x - left, rect.y - down, 
				rect.width + right * ExpansionFactor, rect.height + up * ExpansionFactor) : rect;
		}

		public static Rect Indent(this Rect rect, float width, bool isEnabled = IsEnabledDefault)
		{
			return isEnabled ? new Rect(rect.x + width, rect.y, rect.width - width, rect.height) : rect;
		}

		public static Rect Indent(this Rect rect, int deltaLevel = Int.One, bool isEnabled = IsEnabledDefault)
		{
			return isEnabled ? rect.Indent(deltaLevel * IndentationWidth) : rect;
		}

		public static Rect RoundToMid(this Rect rect, bool isEnabled = IsEnabledDefault)
		{
			if(!isEnabled)
			{
				return rect;
			}
			rect.xMin = rect.xMin.RoundToMid();
			rect.yMin = rect.yMin.RoundToMid();
			rect.xMax = rect.xMax.RoundToMid();
			rect.yMax = rect.yMax.RoundToMid();
			return rect;
		}
		#endregion
	}
}