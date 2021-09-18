namespace WellDefinedTypes
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;

	public static class TypeUtility
	{
		#region Constants
		private static readonly Dictionary<string, Type> aliasedTypes = new KeyValuePair<string, Type>[] {
			GetAliasedType<bool>("bool"), 
			GetAliasedType<byte>("byte"), 
			GetAliasedType<char>("char"), 
			GetAliasedType<decimal>("decimal"), 
			GetAliasedType<double>("double"), 
			GetAliasedType<float>("float"), 
			GetAliasedType<int>("int"), 
			GetAliasedType<sbyte>("sbyte"), 
			GetAliasedType<short>("short"), 
			GetAliasedType<string>("string"), 
			GetAliasedType<long>("long"), 
			GetAliasedType<object>("object"), 
			GetAliasedType<uint>("uint"), 
			GetAliasedType<ulong>("ulong"), 
			GetAliasedType<ushort>("ushort"), 
		}.ToDictionary(type => type.Key, type => type.Value);
		#endregion

		#region Fields
		
		#endregion

		#region Properties
		
		#endregion

		#region Constructors
		
		#endregion

		#region Methods
		/// <remarks>
		/// Tries to get the internal alias of the specified generic Type T as well-definded value if possible, 
		/// else uses the specified fallbackAlias.
		/// </remarks>
		private static KeyValuePair<string, Type> GetAliasedType<T>(string fallbackAlias)
		{
			Type type = typeof(T);
			string alias;
			return new KeyValuePair<string, Type>(type.TryGetAlias(out alias) ? alias : fallbackAlias, type);
		}

		public static Type GetType(string typeName)
		{
			return Type.GetType(typeName) ?? GetTypeFromAlias(typeName);
		}

		public static Type GetTypeFromAlias(string typeName)
		{
			Type type;
			return aliasedTypes.TryGetValue(typeName, out type) ? type : null;
		}
		#endregion
	}
}