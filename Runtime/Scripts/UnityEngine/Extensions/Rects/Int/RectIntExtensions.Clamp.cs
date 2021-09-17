namespace WellDefined
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class RectIntExtensions
	{
		#region Fields
		
		#endregion

		#region Properties
		
		#endregion

		#region Constructors
		
		#endregion

		#region Methods
		public static RectInt Clamp(this RectInt rect, RectInt constrainingRect)
		{
			rect.xMin = rect.xMin.Clamp(constrainingRect.xMin, constrainingRect.xMax);
			rect.xMax = rect.xMax.Clamp(constrainingRect.xMin, constrainingRect.xMax);
			rect.yMin = rect.yMin.Clamp(constrainingRect.yMin, constrainingRect.yMax);
			rect.yMax = rect.yMax.Clamp(constrainingRect.yMin, constrainingRect.yMax);
			return rect;
		}
		#endregion
	}
}