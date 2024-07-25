using VSmart_Editor.Types;

namespace VSmart_Editor.Modifiers
{
	public class ModifierRestoreState : ModifierBase
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropOperation_RestoreState");
		[SmartProperty("StateName", "m_StateName")]
        public AttributeChoice StateName { get; set; } = new(AttributeChoice.Choice.STRING, (int)AttributeChoice.Choice.STRING);

		[SmartProperty("DiscardIfUnknown", "m_bDiscardIfUnknown")]
		public AttributeChoice DiscardIfUnknown { get; set; } = new AttributeChoice(AttributeChoice.Choice.BOOL, (int)AttributeChoice.Choice.BOOL);
	}
}
