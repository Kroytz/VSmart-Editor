using VSmart_Editor.Types;

namespace VSmart_Editor
{
	[Tooltip("Color Choice", "Constant color or a Variable Source")]
	public class AttributeColorChoice
	{
		[SmartProperty("Color", "m_Color")]
		public AttributeChoice Color { get; set; } = new(AttributeChoice.Choice.COLOR, (int)AttributeChoice.Choice.COLOR | (int)AttributeChoice.Choice.VARIABLE_SOURCE);
		[SmartProperty("Weight", "m_flWeight")]
		public AttributeChoice Weight { get; set; } = new(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.COMMON);
	}
}
