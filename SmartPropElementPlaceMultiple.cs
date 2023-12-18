using VSmart_Editor.Types;

namespace VSmart_Editor.Elements
{
	[Tooltip("Place Multiple", "Repeatedly place child elements according to the Count.")]
	public class SmartPropElementPlaceMultiple : SmartPropElement
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropElement_PlaceMultiple");
		public override string DisplayName => "Place Multiple";
		[SmartProperty("Count", "m_nCount")]
		public AttributeChoice Count { get; set; } = new AttributeChoice(AttributeChoice.Choice.INT, (int)AttributeChoice.Choice.INT | (int)AttributeChoice.Choice.COMMON);
	}
}
