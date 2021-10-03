namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
	using UnityEngine;

	public static partial class RectExtensions
	{
		public static Rect Indent(this Rect rect, float width, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? new Rect(rect.x + width, rect.y, rect.width - width, rect.height) : rect;
		}

		public static Rect Indent(this Rect rect, int deltaLevel = Int.One, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? rect.Indent(deltaLevel * Rectangle.IndentationWidth) : rect;
		}
	}
}