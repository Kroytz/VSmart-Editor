namespace VSmart_Editor.Types
{
	public class AttributeVariableNameReference : SmartProperty, IVSmartSerializer
	{
		public AttributeVariableSource Variable { get; set; } = new AttributeVariableSource();

		public override void Render(string DisplayName = "", string NameInVsmart = "")
		{
			Variable.Render(DisplayName, NameInVsmart);
		}

		public string Serialize()
		{
			if (Variable.VariableSource == null)
				return "\"\"";

			return Variable.VariableSource.VariableName.Serialize();
		}
	}
}
