using VSmart_Editor.Types;

namespace VSmart_Editor.Modifiers
{
	public class ModifierSaveState : ModifierBase
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropOperation_SaveState");
		[SmartProperty("StateName", "m_StateName")]
        public AttributeChoice StateName { get; set; } = new(AttributeChoice.Choice.STRING, (int)AttributeChoice.Choice.STRING);
	}
}
