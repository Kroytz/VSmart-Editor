using VSmart_Editor.Types;

namespace VSmart_Editor.Modifiers
{
	[Tooltip("Set Tint Color", "Tints the element")]
	public class ModifierSetTintColor : ModifierBase
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropOperation_SetTintColor");
		[SmartProperty("Color Mode", "m_Mode")]
		public AttributeChoice ColorMode { get; set; } = new(AttributeChoice.Choice.APPLY_COLOR_MODE, (int)AttributeChoice.Choice.APPLY_COLOR_MODE);
		[SmartProperty("Color Choices", "m_ColorChoices")]
		public AttributeList<AttributeColorChoice> ColorChoices { get; set; } = new();
	}
}
