using VSmart_Editor.Types;

namespace VSmart_Editor.Criteria;

[Tooltip("End Cap", "Used in conjunction with a Fit On Line to place this element at the Start and End of the line.")]
public class CriteriaEndCap : CriteriaBase
{
	public override AttributeString ClassName => new AttributeString("CSmartPropSelectionCriteria_EndCap");
	[SmartProperty("Allow at Start", "m_bStart")]
	public AttributeChoice AllowStart { get; set; } = new AttributeChoice(AttributeChoice.Choice.BOOL, (int)AttributeChoice.Choice.BOOL | (int)AttributeChoice.Choice.VARIABLE_SOURCE | (int)AttributeChoice.Choice.EXPRESSION);
	[SmartProperty("Allow at End", "m_bEnd")]
	public AttributeChoice AllowEnd { get; set; } = new AttributeChoice(AttributeChoice.Choice.BOOL, (int)AttributeChoice.Choice.BOOL | (int)AttributeChoice.Choice.VARIABLE_SOURCE | (int)AttributeChoice.Choice.EXPRESSION);
}
