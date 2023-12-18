using VSmart_Editor.Types;

namespace VSmart_Editor.Elements
{
	[Tooltip("Smart Prop", "Reference another smart prop")]
	public class SmartPropElementSmartProp : SmartPropElement
	{
		[SmartProperty("Class", "_class")] public override AttributeString ClassName => new AttributeString("CSmartPropElement_SmartProp");
		public override string DisplayName => "Smart Prop";
		[SmartProperty("Model Name", "m_sSmartProp")]
		public AttributeChoice ModelName { get; set; } = new AttributeChoice(AttributeChoice.Choice.STRING, (int)AttributeChoice.Choice.STRING | (int)AttributeChoice.Choice.VARIABLE_SOURCE | (int)AttributeChoice.Choice.EXPRESSION);
		[SmartProperty("Scale", "m_vModelScale")]
		public AttributeChoice Scale { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.VECTOR3D | (int)AttributeChoice.Choice.COMMON);

		public SmartPropElementSmartProp()
		{

		}
	}

}
