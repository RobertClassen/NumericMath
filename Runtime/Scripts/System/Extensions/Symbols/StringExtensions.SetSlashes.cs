namespace WellDefinedValues
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.IO;

	public static partial class StringExtensions
	{
		/// <summary>
		/// Replaces platform-specific slashes with their opposite.
		/// </summary>
		public static string SetAltSlashes(this string text)
		{
			return text.Replace(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
		}

		/// <summary>
		/// Replaces forward slashes with their opposite.
		/// </summary>
		public static string SetBackwardSlashes(this string text)
		{
			return text.Replace(Char.Slash, Char.Backslash);
		}

		/// <summary>
		/// Replaces backward slashes with their opposite.
		/// </summary>
		public static string SetForwardSlashes(this string text)
		{
			return text.Replace(Char.Backslash, Char.Slash);
		}

		/// <summary>
		/// Replaces platform-specific alternate slashes with their opposite.
		/// </summary>
		public static string SetSlashes(this string text)
		{
			return text.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);
		}
	}
}