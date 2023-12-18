using VSmart_Editor.Types;

namespace VSmart_Editor.Elements
{
	[Tooltip("Pick One", "Picks a child element\n\nThese elements can be picked randomly, or from the first child by default.\n\nScroll wheel over the handle in engine to cycle through choices.")]
	public class SmartPropElementPickOne : SmartPropElement
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropElement_PickOne");
		public override string DisplayName => "Pick One";
		[SmartProperty("Selection Mode", "m_SelectionMode")]
		public AttributeChoice SelectionMode { get; set; } = new AttributeChoice(AttributeChoice.Choice.CHOICE_SELECTION_MODE, (int)AttributeChoice.Choice.CHOICE_SELECTION_MODE | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Handle Offset", "m_vHandleOfffset")]
		public AttributeChoice HandleOffset { get; set; } = new AttributeChoice(AttributeChoice.Choice.VECTOR3D, (int)AttributeChoice.Choice.VECTOR3D | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Handle Color", "m_HandleColor")]
		public AttributeChoice HandleColor { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.COLOR | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Handle Size", "m_HandleSize")]
		public AttributeChoice HandleSize { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Handle Shape", "m_HandleShape")]
		public AttributeChoice HandleShape { get; set; } = new AttributeChoice(AttributeChoice.Choice.HANDLE_SHAPE, (int)AttributeChoice.Choice.HANDLE_SHAPE | (int)AttributeChoice.Choice.COMMON);
	}
}
