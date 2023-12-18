using ImGuiNET;

namespace VSmart_Editor.Types
{
	public class AttributeVector2D : SmartProperty, IVSmartSerializer
	{
		public AttributeChoice x { get; set; }
		public AttributeChoice y { get; set; }
		public bool SimpleSerialize { get; set; }
		public AttributeVector2D()
		{
			this.x = new AttributeChoice(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.VARIABLE_SOURCE | (int)AttributeChoice.Choice.EXPRESSION);
			this.y = new AttributeChoice(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.VARIABLE_SOURCE | (int)AttributeChoice.Choice.EXPRESSION);
		}

		public override void Render(string DisplayName, string NameInVsnap)
		{
			const float width = 128f;
			ImGui.Text(DisplayName);
			ImGui.SetNextItemWidth(width);
			x.Render("x", "");
			ImGui.SetNextItemWidth(width);
			y.Render("y", "");
		}

		public string Serialize()
		{
			if (SimpleSerialize)
				return $"[ {x.Serialize}, {y.Serialize} ]";

			string buffer = "";
			buffer += "\n{";
			buffer += "\nm_Components = ";
			buffer += "\n[";
			buffer += x.Serialize();
			buffer += ",\n";
			buffer += y.Serialize();
			buffer += ",\n";
			buffer += "\n]";
			buffer += "\n}";

			return buffer;
		}
	}
}
