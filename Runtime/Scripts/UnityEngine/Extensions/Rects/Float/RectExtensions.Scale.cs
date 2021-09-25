namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
	using UnityEngine;

	public static partial class RectExtensions
	{
		public static Rect ScaleHeight(this Rect rect, float factor, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? rect.SetHeight(rect.height * factor) : rect;
		}

		public static Rect ScaleWidth(this Rect rect, float factor, bool isEnabled = Function.IsEnabledDefault)
		{
			return isEnabled ? rect.SetWidth(rect.width * factor) : rect;
		}
	}
}