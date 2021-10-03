namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using Core;
	using UnityEngine;

	public static partial class RectExtensions
	{
		public static Rect RoundToMid(this Rect rect, bool isEnabled = Function.IsEnabledDefault)
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
	}
}