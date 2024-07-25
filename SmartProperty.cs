using System.Text.Json.Serialization;

namespace VSmart_Editor.Types
{
	[JsonDerivedType(typeof(SmartProperty), "base")]
	[JsonDerivedType(typeof(AttributeBool), "bool")]
	[JsonDerivedType(typeof(AttributeChoice), "choice")]
	[JsonDerivedType(typeof(AttributeColor), "color")]
	[JsonDerivedType(typeof(AttributeCombo), "combo")]
	[JsonDerivedType(typeof(AttributeComparison), "comparison")]
	[JsonDerivedType(typeof(AttributeExpression), "expression")]
	[JsonDerivedType(typeof(AttributeFloat), "float")]
	[JsonDerivedType(typeof(AttributeList<object>), "list")]
	[JsonDerivedType(typeof(AttributeSkip), "skip")]
	[JsonDerivedType(typeof(AttributeString), "string")]
	[JsonDerivedType(typeof(AttributeVariableNameReference), "variable_name_reference")]
	[JsonDerivedType(typeof(AttributeVariableSource), "variable_source")]
	[JsonDerivedType(typeof(AttributeVariableValue), "variable_value")]
	[JsonDerivedType(typeof(AttributeSetVariableValue), "set_variable_value")]
	[JsonDerivedType(typeof(AttributeVector3D), "vector3D")]
	public class SmartProperty

	{
		public virtual void Render(string DisplayName = "", string NameInVsmart = "") { }
	}
}
