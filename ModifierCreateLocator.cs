using VSmart_Editor.Types;
namespace VSmart_Editor.Modifiers
{
	public class ModifierCreateLocator : ModifierBase
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropOperation_CreateLocator");

		[SmartProperty("LocatorName", "m_LocatorName")]
		public AttributeChoice LocatorName { get; set; } = new(AttributeChoice.Choice.STRING, (int)AttributeChoice.Choice.STRING);
		[SmartProperty("AllowTranslation", "m_bAllowTranslation")]
		public AttributeChoice AllowTranslation { get; set; } = new AttributeChoice(AttributeChoice.Choice.BOOL, (int)AttributeChoice.Choice.BOOL);
		[SmartProperty("AllowRotation", "m_bAllowRotation")]
		public AttributeChoice AllowRotation { get; set; } = new AttributeChoice(AttributeChoice.Choice.BOOL, (int)AttributeChoice.Choice.BOOL);
		[SmartProperty("DisplayScale", "m_flDisplayScale")]
		public AttributeChoice DisplayScale { get; set; } = new AttributeChoice(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.FLOAT);

	}
}
