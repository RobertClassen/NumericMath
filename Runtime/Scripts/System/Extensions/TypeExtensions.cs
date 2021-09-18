namespace WellDefinedTypes
{
	using System.CodeDom;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Reflection;

	public static class TypeExtensions
	{
		#region Constants
		private const BindingFlags defaultFlags =
			BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
		private static readonly HashSet<Type> numericTypes = new HashSet<Type> {
			typeof(byte),
			typeof(decimal),
			typeof(double),
			typeof(float),
			typeof(int),
			typeof(long),
			typeof(sbyte),
			typeof(short),
			typeof(uint),
			typeof(ulong),
			typeof(ushort),
		};
		#endregion

		#region Fields

		#endregion

		#region Properties

		#endregion

		#region Constructors

		#endregion

		#region Methods
		public static FieldInfo GetFieldRecursive(this Type type, string name, BindingFlags flags = defaultFlags)
		{
			return type.GetField(name, flags) ?? (type.BaseType != null ? type.BaseType.GetFieldRecursive(name, flags) : null);
		}

		public static FieldInfo GetFieldFromPath(this Type type, string path, BindingFlags flags = defaultFlags)
		{
			FieldInfo fieldInfo = null;
			string[] parts = path.Split('.');
			for(int i = Int.Zero; i < parts.Length; i++)
			{
				fieldInfo = type.GetFieldRecursive(parts[i], flags);
				if(fieldInfo == null)
				{
					return null;
				}

				if(fieldInfo.FieldType.IsArray)
				{
					type = fieldInfo.FieldType.GetElementType();
					i += 2;
					continue;
				}

				if(fieldInfo.FieldType.IsGenericType)
				{
					type = fieldInfo.FieldType.GetGenericArgument();
					i += 2;
					continue;
				}

				type = fieldInfo.FieldType;
			}

			return fieldInfo;
		}

		public static Type GetGenericArgument(this Type type, int index = Int.Zero)
		{
			return type.IsGenericType ? type.GetGenericArguments()[index] : null;
		}

		public static bool IsNumericType(this Type type)
		{   
			return numericTypes.Contains(type); 
		}

		public static bool TryGetAlias(this Type type, out string alias)
		{
			#if NET_4_6
			using(Microsoft.CSharp.CSharpCodeProvider provider = new Microsoft.CSharp.CSharpCodeProvider())
			{
				alias = provider.GetTypeOutput(new CodeTypeReference(type));
				return true;
			}
			#else
			alias = type.Name;
			return false;
			#endif
		}
		#endregion
	}
}