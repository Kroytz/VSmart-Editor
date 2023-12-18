using VSmart_Editor.Types;

namespace VSmart_Editor.Modifiers
{
	public class FilterExpression : ModifierBase
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropFilter_Expression");
		[SmartProperty("Expression", "m_Expression")]
		public AttributeString SmartString { get; set; } = new AttributeString();
	}
}
