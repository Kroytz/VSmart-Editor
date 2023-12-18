using ImGuiNET;

namespace VSmart_Editor.Types
{
	internal class AttributeExpression : SmartProperty, IVSmartSerializer
	{
		public string Text { get; set; } = "";
		public override void Render(string DisplayName = "", string NameInVsmart = "")
		{
			ImGui.Text(DisplayName);
			string text = Text;
			ImGui.InputText($"##{GetHashCode()}", ref text, 8192);
			Text = text;
		}

		public string Serialize()
		{
			string buffer = "";
			buffer += $"{{ m_Expression = \" {Text} \" }}";

			return buffer;
		}
	}
}
