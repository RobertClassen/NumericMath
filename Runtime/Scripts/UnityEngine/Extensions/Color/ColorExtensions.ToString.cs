namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public static partial class ColorExtensions
	{
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
	}
}