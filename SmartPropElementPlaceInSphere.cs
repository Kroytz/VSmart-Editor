using VSmart_Editor.Types;

namespace VSmart_Editor.Elements
{
	[Tooltip("Place In Sphere", "Randomly places child elements within a Sphere or Circle.")]
	public class SmartPropElementPlaceInSphere : SmartPropElement
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropElement_PlaceInSphere");
		public override string DisplayName => "Place In Sphere";
		[SmartProperty("Placement Mode", "m_PlacementMode")]
		public AttributeChoice PlacementMode { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.RADIUS_PLACEMENT_MODE | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Distribution Mode", "m_DistributionMode")]
		public AttributeChoice DistributionMode { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.DISTRIBUTION_MODE | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Randomness", "m_flRandomness")]
		public AttributeChoice Randomness { get; set; } = new AttributeChoice(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Plane Up Direction", "m_vPlaneUpDirection")]
		public AttributeChoice PlaneUpDirection { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.VECTOR3D | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Count Min", "m_nCountMin")]
		public AttributeChoice CountMin { get; set; } = new AttributeChoice(AttributeChoice.Choice.INT, (int)AttributeChoice.Choice.INT | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Count Max", "m_nCountMax")]
		public AttributeChoice CountMax { get; set; } = new AttributeChoice(AttributeChoice.Choice.INT, (int)AttributeChoice.Choice.INT | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Radius Inner", "m_flPositionRadiusInner")]
		public AttributeChoice RadiusInner { get; set; } = new AttributeChoice(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Radius Outer", "m_flPositionRadiusOuter")]
		public AttributeChoice RadiusOuter { get; set; } = new AttributeChoice(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Align Orientation", "m_bAlignOrientation")]
		public AttributeChoice AlignRotation { get; set; } = new AttributeChoice(AttributeChoice.Choice.BOOL, (int)AttributeChoice.Choice.BOOL | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Align Direction", "m_vAlignDirection")]
		public AttributeChoice AlignDirection { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.VECTOR3D | (int)AttributeChoice.Choice.COMMON);

	}
}
