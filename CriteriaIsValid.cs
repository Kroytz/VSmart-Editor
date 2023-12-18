using VSmart_Editor.Types;

namespace VSmart_Editor.Criteria;

[Tooltip("Is Valid", "")]
public class CriteriaIsValid : CriteriaBase
{
	public override AttributeString ClassName => new AttributeString("CSmartPropSelectionCriteria_IsValid");
}