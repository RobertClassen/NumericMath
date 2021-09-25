namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static partial class StringExtensions
	{
		/// <summary>
		/// Returns the substring from the specified <c>startIndex</c> to the next occurrence 
		/// of the specified <c>separator</c> if there is one, else to the end of the <c>text</c>.
		/// </summary>
		/// 
		/// <param name="text">The <c>string</c> from which a substring should be returned.></param>
		/// <param name="separator">Determines which (non-inclusive) <c>char</c> 
		/// should mark the end of the returned substring, if <c>text</c> contains it.</param>
		/// <param name="endIndex">Can be used as new <c>startIndex</c> in next iteration, if required.</param>
		/// <param name="startIndex">Must be clamped to the <c>text.Length</c>.</param>
		public static string Substring(this string text, char separator, out int endIndex, int startIndex = 0)
		{
			if(text.IsNullOrEmpty())
			{
				throw new ArgumentNullException(nameof(text));
			}
			if(!startIndex.IsClamped(Int.Zero, text.Length - Int.One))
			{
				throw new ArgumentOutOfRangeException(nameof(startIndex));
			}
			if(!text.Contains(separator))
			{
				endIndex = text.Length;
				return text;
			}

			endIndex = text.IndexOf(separator, startIndex);
			if(endIndex < Int.Zero)
			{
				endIndex = text.Length;
			}
			return text.Substring(startIndex, endIndex++ - startIndex);
		}
	}
}