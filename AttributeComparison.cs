using ImGuiNET;

namespace VSmart_Editor.Types
{
	public class AttributeComparison : SmartProperty, IVSmartSerializer
	{
		public string Selection { get; set; } = "EQUAL";

		public override void Render(string DisplayName = "", string NameInVsmart = "")
		{
			ImGui.Text(DisplayName);
			if ((ImGui.BeginCombo($"##{GetHashCode()}", Selection)))
			{
				if (ImGui.Button($"EQUAL##{GetHashCode()}"))
					Selection = "EQUAL";

				if (ImGui.Button($"NOT_EQUAL##{GetHashCode()}"))
					Selection = "NOT_EQUAL";

				if (ImGui.Button($"LESS##{GetHashCode()}"))
					Selection = "LESS";

				if (ImGui.Button($"LESS_OR_EQUAL##{GetHashCode()}"))
					Selection = "LESS_OR_EQUAL";

				if (ImGui.Button($"GREATER##{GetHashCode()}"))
					Selection = "GREATER";

				if (ImGui.Button($"GREATER_OR_EQUAL##{GetHashCode()}"))
					Selection = "GREATER_OR_EQUAL";
			}
		}

		public string Serialize()
		{
			var smartString = new AttributeString(Selection);
			return smartString.Serialize();
		}
	}
}
