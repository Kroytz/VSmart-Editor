using VSmart_Editor.Types;

namespace VSmart_Editor.Modifiers
{
	public class ModifierRandomScale : ModifierBase
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropOperation_RandomScale");
		[SmartProperty("Min Scale", "m_flRandomScaleMin")]
		public AttributeChoice ScaleMin { get; set; } = new AttributeChoice(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.EXPRESSION | (int)AttributeChoice.Choice.VARIABLE_SOURCE);
		[SmartProperty("Max Scale", "m_flRandomScaleMax")]
		public AttributeChoice ScaleMax { get; set; } = new AttributeChoice(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.EXPRESSION | (int)AttributeChoice.Choice.VARIABLE_SOURCE);
	}
}
