using VSmart_Editor.Types;

namespace VSmart_Editor.Criteria
{
	[Tooltip("Linear Length", "Used in conjunction with a Fit On Line to determine the size of this element.\n\nUse LinearScale() in an expression to scale the model.")]
	public class CriteriaLinearLength : CriteriaBase
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropSelectionCriteria_LinearLength");
		[SmartProperty("Linear Length", "m_flLength")]
		public AttributeChoice Length { get; set; } = new AttributeChoice(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.VARIABLE_SOURCE | (int)AttributeChoice.Choice.EXPRESSION);
		[SmartProperty("Allow Scale", "m_bAllowScale")]
		public AttributeChoice AllowScale { get; set; } = new AttributeChoice(AttributeChoice.Choice.BOOL, (int)AttributeChoice.Choice.BOOL | (int)AttributeChoice.Choice.VARIABLE_SOURCE | (int)AttributeChoice.Choice.EXPRESSION);
		[SmartProperty("Minimum Length", "m_flMinLength")]
		public AttributeChoice MinLength { get; set; } = new AttributeChoice(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.VARIABLE_SOURCE | (int)AttributeChoice.Choice.EXPRESSION);
		[SmartProperty("Maximum Length", "m_flMaxLength")]
		public AttributeChoice MaxLength { get; set; } = new AttributeChoice(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.VARIABLE_SOURCE | (int)AttributeChoice.Choice.EXPRESSION);
	}
}
