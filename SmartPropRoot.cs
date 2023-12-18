using VSmart_Editor.Types;
using VSmart_Editor.Variables;

namespace VSmart_Editor.Elements
{
	[HideInObjectPicker]
	public class SmartPropRoot : SmartPropElement
	{
		[IgnoreSerializer, HideProperty] public override AttributeString ClassName => base.ClassName;
		[SmartProperty("Generic Data Type", "generic_data_type")] public AttributeString DataKey => new AttributeString("CSmartPropRoot");
		[SmartProperty("Variables", "m_Variables")] public AttributeList<SmartPropVariable> Variables { get; set; } = new();
		public string GetMembersAsString()
		{
			throw new NotImplementedException();
		}

		public string GetModifiersAsString()
		{
			throw new NotImplementedException();
		}

		public string Serialize()
		{
			string buffer = "";
			buffer += "<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:vrfunknown:version{5ab656f0-06de-478a-804e-489e82994fb5} -->";
			buffer += "\n{\n";
			buffer += "\t\t// CREATED WITH GUNNAR KAFEL'S VSMART EDITOR";
			buffer += "\t\t// github.com/gunnarkafel";
			buffer += "generic_data_type = \"CSmartPropRoot\"";
			buffer += "\nm_Children = \n[";
			buffer += GetMembersAsString();
			buffer += "\n]\n";
			buffer += "}";

			return buffer;
		}
	}
}
