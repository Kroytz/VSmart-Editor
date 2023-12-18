using ImGuiNET;

namespace VSmart_Editor.Types
{
	public class AttributeString : SmartProperty, IVSmartSerializer
	{
		public string Value { get; set; } = "";

		public AttributeString() { }
		public AttributeString(string value) { Value = value; }

		public string GetMembersAsString()
		{
			return "";
		}

		public string GetModifiersAsString()
		{
			return "";
		}

		public override void Render(string DisplayName = "", string NameInVsmart = "")
		{
			string buffer = Value;
			ImGui.Text(DisplayName);
			ImGui.InputText($"##{GetHashCode()}", ref buffer, 512);
			Value = buffer;
		}

		public string Serialize()
		{
			return $"\"{Value}\"";
		}
	}
}
