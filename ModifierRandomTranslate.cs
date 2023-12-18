using VSmart_Editor.Types;

namespace VSmart_Editor.Modifiers
{
	public class ModifierRandomTranslate : ModifierBase
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropOperation_RandomOffset");
		[SmartProperty("Min Offset", "m_vRandomPositionMin")]
		public AttributeChoice MoveMin { get; set; } = new AttributeChoice(AttributeChoice.Choice.VECTOR3D, (int)AttributeChoice.Choice.VECTOR3D | (int)AttributeChoice.Choice.EXPRESSION | (int)AttributeChoice.Choice.VARIABLE_SOURCE);
		[SmartProperty("Max Offset", "m_vRandomPositionMax")]
		public AttributeChoice MoveMax { get; set; } = new AttributeChoice(AttributeChoice.Choice.VECTOR3D, (int)AttributeChoice.Choice.VECTOR3D | (int)AttributeChoice.Choice.EXPRESSION | (int)AttributeChoice.Choice.VARIABLE_SOURCE);
	}
}
