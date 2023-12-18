using ImGuiNET;

namespace VSmart_Editor.Types
{
	public class AttributeCombo : SmartProperty, IVSmartSerializer
	{
		public string[] Choices { get; set; } = { "CHOICE_1", "CHOICE_2", };
		public AttributeString CurrentChoice { get; set; } = new AttributeString();
		public bool Value { get; set; }

		public AttributeCombo() { }
		public AttributeCombo(string[] choices)
		{
			Choices = choices;
			CurrentChoice = new AttributeString(choices[0]);
		}

		public override void Render(string DisplayName = "", string NameInVsmart = "")
		{
			ImGui.Text(DisplayName);
			if (ImGui.BeginCombo($"##{GetHashCode()}", CurrentChoice.Value))
			{
				foreach (var choice in Choices)
				{
					if (ImGui.Button(choice))
					{
						CurrentChoice.Value = choice;
					}
				}
				ImGui.EndCombo();
			}
		}

		public string Serialize()
		{
			return CurrentChoice.Serialize();
		}
	}
}
