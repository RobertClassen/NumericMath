namespace WellDefinedTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class RectExtensions
	{
		#region Fields
		
		#endregion

		#region Properties
		
		#endregion

		#region Constructors
		
		#endregion

		#region Methods
		public static Rect Clamp(this Rect rect, Rect constrainingRect, bool isEnabled = IsEnabledDefault)
		{
			if(!isEnabled)
			{
				return rect;
			}
			rect.xMin = rect.xMin.Clamp(constrainingRect.xMin, constrainingRect.xMax);
			rect.xMax = rect.xMax.Clamp(constrainingRect.xMin, constrainingRect.xMax);
			rect.yMin = rect.yMin.Clamp(constrainingRect.yMin, constrainingRect.yMax);
			rect.yMax = rect.yMax.Clamp(constrainingRect.yMin, constrainingRect.yMax);
			return rect;
		}
		#endregion
	}
}