namespace WellDefinedTypes
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
		public static Rect Scale(this RectInt rect, Vector2 scale)
		{
			return new Rect(rect.position * scale, rect.size * scale);
		}
		#endregion
	}
}