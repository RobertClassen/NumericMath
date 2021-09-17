namespace UnityEngine.Extensions
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Extensions;
	using System.Utilities;
	using String = System.Utilities.String;

	public static class ColorExtensions
	{
		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
		public static Color Clamp(this Color color, Color min, Color max)
		{
			return new Color(
				color.r.Clamp(min.r, max.r), 
				color.g.Clamp(min.g, max.g), 
				color.b.Clamp(min.b, max.b), 
				color.a.Clamp(min.a, max.a));
		}

		public static Color Clamp01(this Color color, bool isClamped = Numeric.IsClampClampedDefault)
		{
			return isClamped ? new Color(
				color.r.Clamp01(), 
				color.g.Clamp01(), 
				color.b.Clamp01(), 
				color.a.Clamp01()) : 
				color;
		}

		public static Color SetAlpha(this Color color, float alpha)
		{
			color.a = alpha;
			return color;
		}

		/// <summary>
		/// Returns a hexadecimal <c>string</c> representation of the <c>Color</c> in the format "#RRGGBB".
		/// </summary>
		public static string ToHexStringRGB(this Color color)
		{
			return String.Hashtag + ColorUtility.ToHtmlStringRGB(color);
		}

		/// <summary>
		/// Returns a hexadecimal <c>string</c> representation of the <c>Color</c> in the format "#RRGGBBAA".
		/// </summary>
		public static string ToHexStringRGBA(this Color color)
		{
			return String.Hashtag + ColorUtility.ToHtmlStringRGBA(color);
		}
		#endregion
	}
}