using ImGuiNET;

namespace VSmart_Editor.Types
{
	public class AttributeSkip : SmartProperty, IVSmartSerializer
	{
		public override void Render(string DisplayName = "", string NameInVsmart = "")
		{
			ImGui.Text(DisplayName);
		}
		public string Serialize()
		{
			return "SKIPPED IN SERIALIZER";
		}
	}
}
