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
		public static Rect AddX(this Rect rect, float x, bool isEnabled = IsEnabledDefault)
		{
			return isEnabled ? new Rect(rect.x + x, rect.y, rect.width, rect.height) : rect;
		}

		public static Rect AddXMax(this Rect rect, float x, bool isEnabled = IsEnabledDefault)
		{
			return isEnabled ? new Rect(rect.x, rect.y, rect.width + x, rect.height) : rect;
		}

		public static Rect AddXMin(this Rect rect, float x, bool isEnabled = IsEnabledDefault)
		{
			return isEnabled ? new Rect(rect.x + x, rect.y, rect.width - x, rect.height) : rect;
		}

		public static Rect AddY(this Rect rect, float y, bool isEnabled = IsEnabledDefault)
		{
			return isEnabled ? new Rect(rect.x, rect.y + y, rect.width, rect.height) : rect;
		}

		public static Rect AddYMax(this Rect rect, float y, bool isEnabled = IsEnabledDefault)
		{
			return isEnabled ? new Rect(rect.x, rect.y, rect.width, rect.height + y) : rect;
		}

		public static Rect AddYMin(this Rect rect, float y, bool isEnabled = IsEnabledDefault)
		{
			return isEnabled ? new Rect(rect.x, rect.y + y, rect.width, rect.height - y) : rect;
		}
		#endregion
	}
}