using VSmart_Editor.Types;

namespace VSmart_Editor.Modifiers
{
	public class FilterProbability : ModifierBase
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropFilter_Probability");
		[SmartProperty("Probability", "m_flProbability")]
		public AttributeChoice Probability { get; set; } = new AttributeChoice(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.EXPRESSION | (int)AttributeChoice.Choice.VARIABLE_SOURCE);
	}
}