using ImGuiNET;

namespace VSmart_Editor.Types
{
	public class AttributeBool : SmartProperty, IVSmartSerializer
	{
		public bool Value { get; set; }

		public override void Render(string DisplayName = "", string NameInVsmart = "")
		{
			ImGui.Text(DisplayName);

			bool value = Value;
			ImGui.Checkbox($"##{GetHashCode()}", ref value);
			Value = value;
		}

		public string Serialize()
		{
			return Value ? "true" : "false";
		}
	}
}
