using VSmart_Editor.Types;

namespace VSmart_Editor.Elements
{
	[Tooltip("Model", "Reference a vmdl to show in engine")]
	internal class SmartPropElementModel : SmartPropElement
	{
		[SmartProperty("Class", "_class")]
		public override AttributeString ClassName => new AttributeString("CSmartPropElement_Model");
		public override string DisplayName => "Model";
		[SmartProperty("Model Name", "m_sModelName")]
		public AttributeChoice ModelName { get; set; } = new AttributeChoice(AttributeChoice.Choice.STRING, (int)AttributeChoice.Choice.STRING | (int)AttributeChoice.Choice.VARIABLE_SOURCE | (int)AttributeChoice.Choice.EXPRESSION);
		[SmartProperty("Scale", "m_vModelScale")]
		public AttributeChoice Scale { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.VECTOR3D | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Material Group", "m_MaterialGroupName")]
		public AttributeChoice MaterialGroup { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.STRING | (int)AttributeChoice.Choice.COMMON);
	}

}
