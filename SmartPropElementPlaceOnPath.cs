using VSmart_Editor.Types;

namespace VSmart_Editor.Elements
{
	[Tooltip("Place On Path", "Place child elements along a Path defined in Hammer.")]
	public class SmartPropElementPlaceOnPath : SmartPropElement
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropElement_PlaceOnPath");
		public override string DisplayName => "Place On Path";
		[SmartProperty("Path Name", "m_PathName")]
		public AttributeString PathName { get; set; } = new AttributeString("path");
		[SmartProperty("Path Offset", "m_vPathOffset")]
		public AttributeChoice PathOffset { get; set; } = new(AttributeChoice.Choice.VECTOR3D, (int)AttributeChoice.Choice.VECTOR3D | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Offset Along Path", "m_flOffsetAlongPath")]
		public AttributeChoice OffsetAlongPath { get; set; } = new(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Path Space", "m_PathSpace")]
		public AttributeChoice PathSpace { get; set; } = new(AttributeChoice.Choice.COORDINATE_SPACE, (int)AttributeChoice.Choice.COORDINATE_SPACE | (int)AttributeChoice.Choice.COMMON);
	}
}
