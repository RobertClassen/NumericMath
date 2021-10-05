namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
	using UnityEngine;

	public static partial class RectExtensions
	{
		/// <summary>
		/// Sets the bounds of the rect to the <c>min</c> and <c>max</c> values.
		/// </summary>
		public static Rect Set(this Rect rect, Vector2 min, Vector2 max, bool isEnabled = Function.IsEnabledDefault)
		{
			if(isEnabled)
			{
				rect.min = min;
				rect.max = max;
			}
			return rect;
		}

		public static Rect SetHeight(this Rect rect, float height, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? rect.SetSize(rect.width, height) : rect;
		}

		public static Rect SetIndentation(this Rect rect, int indentationLevel, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? rect.SetXMin(indentationLevel * Rectangle.IndentationWidth) : rect;
		}

		public static Rect SetMax(this Rect rect, Vector2 max, bool isEnabled = Function.IsEnabledDefault)
		{
			if(isEnabled)
			{
				rect.max = max;
			}
			return rect;
		}

		public static Rect SetMin(this Rect rect, Vector2 min, bool isEnabled = Function.IsEnabledDefault)
		{
			if(isEnabled)
			{
				rect.min = min;
			}
			return rect;
		}

		public static Rect SetSize(this Rect rect, Vector2 size, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? new Rect(rect.position, size) : rect;
		}

		public static Rect SetSize(this Rect rect, float width, float height, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? rect.SetSize(new Vector2(width, height)) : rect;
		}

		public static Rect SetWidth(this Rect rect, float width, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? rect.SetSize(width, rect.height) : rect;
		}

		public static Rect SetX(this Rect rect, float x, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? new Rect(x, rect.y, rect.width, rect.height) : rect;
		}

		public static Rect SetXMax(this Rect rect, float x, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? new Rect(rect.x, rect.y, x - rect.x, rect.height) : rect;
		}

		public static Rect SetXMin(this Rect rect, float x, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? new Rect(x, rect.y, rect.width + rect.x - x, rect.height) : rect;
		}

		public static Rect SetY(this Rect rect, float y, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? new Rect(rect.x, y, rect.width, rect.height) : rect;
		}

		public static Rect SetYMax(this Rect rect, float y, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? new Rect(rect.x, rect.y, rect.width, y - rect.y) : rect;
		}

		public static Rect SetYMin(this Rect rect, float y, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? new Rect(rect.x, y, rect.width, rect.height + rect.y - y) : rect;
		}
	}
}