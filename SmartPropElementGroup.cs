using VSmart_Editor.Types;

namespace VSmart_Editor.Elements
{
	[Tooltip("Group", "Used to group elements together")]
	public class SmartPropElementGroup : SmartPropElement
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropElement_Group");
		public override string DisplayName => "Group";
	}
}
