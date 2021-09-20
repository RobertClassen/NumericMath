namespace WellDefinedValues
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
		public static Rect ScaleHeight(this Rect rect, float factor, bool isEnabled = IsEnabledDefault)
		{
			return isEnabled ? rect.SetHeight(rect.height * factor) : rect;
		}

		public static Rect ScaleWidth(this Rect rect, float factor, bool isEnabled = IsEnabledDefault)
		{
			return isEnabled ? rect.SetWidth(rect.width * factor) : rect;
		}
		#endregion
	}
}