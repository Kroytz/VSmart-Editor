namespace VSmart_Editor.Types
{
	public class AttributeSetVariableValue : SmartProperty, IVSmartSerializer
	{
		public AttributeVariableNameReference Name { get; set; } = new AttributeVariableNameReference();
		public AttributeChoice Choice { get; set; } = new AttributeChoice(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.ALL);

		public override void Render(string DisplayName = "", string NameInVsmart = "")
		{
			Name.Render("Name");
			Choice.Render("Value");
		}

		public string Serialize()
		{
			string buffer = "";
			buffer += "\n{\n";
			buffer += $"\tm_Name = {Name.Serialize()}\n";
            buffer += $"\tm_DataType = {"\""+Choice.GetSelectedChoice()+"\""}\n";
			buffer += $"\tm_Value = {Choice.Serialize()}\n";
			buffer += "}\n";

			return buffer;
		}
	}
}
