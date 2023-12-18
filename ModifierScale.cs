using VSmart_Editor.Types;

namespace VSmart_Editor.Modifiers
{
	public class ModifierScale : ModifierBase
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropOperation_Scale");
		[SmartProperty("Scale", "m_flScale")]
		public AttributeChoice Scale { get; set; } = new AttributeChoice(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.EXPRESSION | (int)AttributeChoice.Choice.VARIABLE_SOURCE);
	}
}
