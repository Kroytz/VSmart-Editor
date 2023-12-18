namespace VSmart_Editor
{
	internal class SmartPropertyAttribute : Attribute
	{
		public string DisplayName;
		public string NameInVsmart;
		public SmartPropertyAttribute(string displayName, string nameInVsmart)
		{
			DisplayName = displayName;
			NameInVsmart = nameInVsmart;
		}
	}
}
