using VSmart_Editor.Types;

namespace VSmart_Editor.Modifiers
{
	public class FilterVariableValue : ModifierBase
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropFilter_VariableValue");
		[SmartProperty("Variable Comparison", "m_VariableComparison")]
		public AttributeVariableValue ValueComparison { get; set; } = new AttributeVariableValue();
	}
}
