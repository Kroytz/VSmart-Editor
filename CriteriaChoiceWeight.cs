using VSmart_Editor.Types;

namespace VSmart_Editor.Criteria;

[Tooltip("Choice Weight", "Biases the chance of this element being chosen")]
public class CriteriaChoiceWeight : CriteriaBase
{
	public override AttributeString ClassName => new AttributeString("CSmartPropSelectionCriteria_ChoiceWeight");
	[SmartProperty("Choice Weight", "m_flWeight")]
	public AttributeChoice ChoiceWeight { get; set; } = new AttributeChoice(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.VARIABLE_SOURCE | (int)AttributeChoice.Choice.EXPRESSION);
}
