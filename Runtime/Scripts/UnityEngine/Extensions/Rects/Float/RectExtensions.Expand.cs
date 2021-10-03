namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
	using UnityEngine;

	public static partial class RectExtensions
	{
		public static Rect Expand(this Rect rect, float margin, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? rect.Expand(margin, margin, margin, margin) : rect;
		}

		public static Rect Expand(this Rect rect, float x, float y, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? rect.Expand(x, x, y, y) : rect;
		}

		public static Rect Expand(this Rect rect, float left, float right, float down, float up, 
			bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? new Rect(rect.x - left, rect.y - down, 
				rect.width + right * Rectangle.ExpansionFactor, rect.height + up * Rectangle.ExpansionFactor) : rect;
		}
	}
}