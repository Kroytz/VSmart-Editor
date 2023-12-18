using VSmart_Editor.Types;

namespace VSmart_Editor.Elements
{
	[Tooltip("Modify State", "Used to apply modifiers to a parent element\n\nCan be Filtered to have conditional modifiers")]
	public class SmartPropElementModifyState : SmartPropElement
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropElement_ModifyState");
		public override string DisplayName => "Modify State";
	}
}
