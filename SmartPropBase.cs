using VSmart_Editor.Types;

namespace VSmart_Editor
{
	public abstract class SmartPropBase
	{
		[SmartProperty("Comment", "m_sLabel")] public AttributeString Label { get; set; } = new AttributeString();
	}
}
