using VSmart_Editor.Types;

namespace VSmart_Editor.Modifiers
{
	public class ModifierRandomRotate : ModifierBase
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropOperation_RandomRotation");
		[SmartProperty("Min Rotation", "m_vRandomRotationMin")]
		public AttributeChoice RotMin { get; set; } = new AttributeChoice(AttributeChoice.Choice.VECTOR3D, (int)AttributeChoice.Choice.VECTOR3D | (int)AttributeChoice.Choice.EXPRESSION | (int)AttributeChoice.Choice.VARIABLE_SOURCE);
		[SmartProperty("Max Rotation", "m_vRandomRotationMax")]
		public AttributeChoice RotMax { get; set; } = new AttributeChoice(AttributeChoice.Choice.VECTOR3D, (int)AttributeChoice.Choice.VECTOR3D | (int)AttributeChoice.Choice.EXPRESSION | (int)AttributeChoice.Choice.VARIABLE_SOURCE);
	}
}
