using ImGuiNET;

namespace VSmart_Editor.Types;
public class AttributeFloat : SmartProperty, IVSmartSerializer
{
	public float Value { get; set; }
	string textInput;

	public AttributeFloat() { }
	public AttributeFloat(float value) { Value = value; }

	public string GetMembersAsString()
	{
		return "";
	}

	public string GetModifiersAsString()
	{
		return "";
	}

	public override void Render(string DisplayName, string NameInVsnap)
	{
		textInput = Value.ToString();
		if (DisplayName != "")
			ImGui.Text(DisplayName);
		ImGui.InputText($"##{GetHashCode()}", ref textInput, 64);
		float value = Value;
		float.TryParse(textInput, out value);
		Value = value;
	}

	public string Serialize()
	{
		return $"{Value}";
	}
}
