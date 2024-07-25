using VSmart_Editor.Types;

namespace VSmart_Editor.Modifiers
{
	public class ModifierSetVariableValue : ModifierBase
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropOperation_SetVariable");
        [SmartProperty("Variable Comparison", "m_VariableValue")]
		public AttributeSetVariableValue ValueComparison { get; set; } = new AttributeSetVariableValue();
	}
}
