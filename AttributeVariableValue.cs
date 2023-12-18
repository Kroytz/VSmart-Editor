namespace VSmart_Editor.Types
{
	public class AttributeVariableValue : SmartProperty, IVSmartSerializer
	{
		public AttributeVariableNameReference Name { get; set; } = new AttributeVariableNameReference();
		public AttributeChoice ChoiceValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.ALL);
		public AttributeComparison Comparison { get; set; } = new AttributeComparison();

		public override void Render(string DisplayName = "", string NameInVsmart = "")
		{
			Name.Render("Name");
			ChoiceValue.Render("Value");
			Comparison.Render("Comparison");
		}

		public string Serialize()
		{
			string buffer = "";
			buffer += "\n{\n";
			buffer += $"\tm_Name = {Name.Serialize()}\n";
			buffer += $"\tm_Value = {ChoiceValue.Serialize()}\n";
			buffer += $"\tm_Comparison = {Comparison.Serialize()}\n";
			buffer += "}\n";

			return buffer;
		}
	}
}
