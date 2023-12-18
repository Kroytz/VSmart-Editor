using VSmart_Editor.Types;

namespace VSmart_Editor.Modifiers
{
	public class ModifierCreateRotator : ModifierBase
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropOperation_CreateRotator");
		[SmartProperty("Rotation Axis", "m_vRotationAxis")]
		public AttributeChoice RotationAxis { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.VECTOR3D | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Coordinate Space", "m_CoordinateSpace")]
		public AttributeChoice CoordSpace { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.COORDINATE_SPACE | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Display Radius", "m_flDisplayRadius")]
		public AttributeChoice DisplayRadiuss { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Apply To Current Transform", "m_bApplyToCurrentTrasnform")]
		public AttributeChoice ApplyToTransform { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.BOOL | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Output Variable", "m_OutputVariable")]
		public AttributeChoice OutputVariable { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.VARIABLE_NAME | (int)AttributeChoice.Choice.COMMON);
	}
}
