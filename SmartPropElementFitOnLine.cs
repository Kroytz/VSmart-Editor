using VSmart_Editor.Types;

namespace VSmart_Editor.Elements
{
	[Tooltip("Fit On Line", "Used to place elements along a path. \n\nElements require a Linear Length criterion, and an optional End Cap criterion to appear at the start or end. \n\nThe amount to scale an element can be referenced with LinearScale() in an Expression.")]
	internal class SmartPropElementFitOnLine : SmartPropElement
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropElement_FitOnLine");
		public override string DisplayName => "Fit On Line";
		[SmartProperty("Start Point", "m_vStart")]
		public AttributeChoice StartPoint { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.VECTOR3D | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("End Point", "m_vEnd")]
		public AttributeChoice EndPoint { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.VECTOR3D | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Point Space", "m_PointSpace")]
		public AttributeChoice PointSpace { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.COORDINATE_SPACE | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Orient Along Line", "m_bOrientAlongLine")]
		public AttributeChoice OrientAlongLine { get; set; } = new AttributeChoice(AttributeChoice.Choice.BOOL, (int)AttributeChoice.Choice.BOOL | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Up Direction", "m_vUpDirection")]
		public AttributeChoice UpDirection { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.VECTOR3D | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Scale Mode", "m_nScaleMode")]
		public AttributeChoice ScaleMode { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.SCALE_MODE | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Pick Mode", "m_nPickMode")]
		public AttributeChoice PickMode { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.PICK_MODE | (int)AttributeChoice.Choice.COMMON);
	}
}
