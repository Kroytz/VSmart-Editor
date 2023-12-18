namespace VSmart_Editor
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class TooltipAttribute : Attribute
	{
		public string Title { get; set; }
		public string Tooltip { get; set; }
		public TooltipAttribute(string title, string tip)
		{
			Tooltip = tip;
			Title = title;
		}
	}
}
