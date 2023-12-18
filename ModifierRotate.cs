using VSmart_Editor.Types;

namespace VSmart_Editor.Modifiers
{
	public class ModifierRotate : ModifierBase
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropOperation_Rotate");
		[SmartProperty("Rotation", "m_vRotation")]
		public AttributeChoice Rotation { get; set; } = new AttributeChoice(AttributeChoice.Choice.VECTOR3D, (int)AttributeChoice.Choice.VECTOR3D | (int)AttributeChoice.Choice.EXPRESSION | (int)AttributeChoice.Choice.VARIABLE_SOURCE);
	}
}
