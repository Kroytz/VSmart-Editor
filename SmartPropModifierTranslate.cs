using VSmart_Editor.Types;

namespace VSmart_Editor.Modifiers
{
	public class ModifierTranslate : ModifierBase
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropOperation_Translate");
		[SmartProperty("Position", "m_vPosition")]
		public AttributeChoice Offset { get; set; } = new AttributeChoice(AttributeChoice.Choice.VECTOR3D, (int)AttributeChoice.Choice.VECTOR3D | (int)AttributeChoice.Choice.EXPRESSION | (int)AttributeChoice.Choice.VARIABLE_SOURCE);
	}
}
