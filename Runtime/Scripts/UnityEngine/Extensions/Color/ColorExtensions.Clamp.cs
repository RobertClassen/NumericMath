namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class ColorExtensions
	{
		public static Color Clamp(this Color color, Color min, Color max)
		{
			return new Color(
				color.r.Clamp(min.r, max.r), 
				color.g.Clamp(min.g, max.g), 
				color.b.Clamp(min.b, max.b), 
				color.a.Clamp(min.a, max.a));
		}

		public static Color Clamp01(this Color color, bool isEnabled = Core.Numeric.IsClampEnabledDefault)
		{
			return isEnabled ? new Color(
				color.r.Clamp01(), 
				color.g.Clamp01(), 
				color.b.Clamp01(), 
				color.a.Clamp01()) : 
				color;
		}
	}
}