using VSmart_Editor.Types;

namespace VSmart_Editor.Modifiers
{
	public class FilterSurfaceAngle : ModifierBase
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropFilter_SurfaceAngle");
		[SmartProperty("Minimum Slope", "m_flSurfaceSlopeMin")]
		public AttributeChoice SlopeMin { get; set; } = new AttributeChoice(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.EXPRESSION | (int)AttributeChoice.Choice.VARIABLE_SOURCE);
		[SmartProperty("Maximum Slope", "m_flSurfaceSlopeMax")]
		public AttributeChoice SlopeMax { get; set; } = new AttributeChoice(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.EXPRESSION | (int)AttributeChoice.Choice.VARIABLE_SOURCE);
	}
}