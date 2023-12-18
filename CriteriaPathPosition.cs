using VSmart_Editor.Types;

namespace VSmart_Editor.Criteria;


[Tooltip("Path Positions", "Determines where the element will be placed in a Place On Path element.")]
public class CriteriaPathPositions : CriteriaBase
{
	public override AttributeString ClassName => new AttributeString("CSmartPropSelectionCriteria_PathPosition");
	static string[] choices = { "ALL", "NTH" };
	[SmartProperty("Place at Positions", "m_PlaceAtPositions")]
	public AttributeChoice PlaceAtPositions { get; set; } = new AttributeChoice(AttributeChoice.Choice.PATH_POSITIONS, (int)AttributeChoice.Choice.PATH_POSITIONS | (int)AttributeChoice.Choice.EXPRESSION | (int)AttributeChoice.Choice.VARIABLE_SOURCE);
	[SmartProperty("Place Every Nth Position", "m_nPlaceEveryNthPosition")]
	public AttributeChoice PlaceEveryNth { get; set; } = new AttributeChoice(AttributeChoice.Choice.INT, (int)AttributeChoice.Choice.INT | (int)AttributeChoice.Choice.EXPRESSION | (int)AttributeChoice.Choice.VARIABLE_SOURCE);
	[SmartProperty("Nth Position Index Offset", "m_nNthPositionIndexOffset")]
	public AttributeChoice NthIndexOffset { get; set; } = new AttributeChoice(AttributeChoice.Choice.INT, (int)AttributeChoice.Choice.INT | (int)AttributeChoice.Choice.EXPRESSION | (int)AttributeChoice.Choice.VARIABLE_SOURCE);
	[SmartProperty("Allow at Start", "m_bAllowAtStart")]
	public AttributeChoice AllowAtStart { get; set; } = new AttributeChoice(AttributeChoice.Choice.BOOL, (int)AttributeChoice.Choice.BOOL | (int)AttributeChoice.Choice.EXPRESSION | (int)AttributeChoice.Choice.VARIABLE_SOURCE);
	[SmartProperty("Allow at End", "m_bAllowAtEnd")]
	public AttributeChoice AllowAtEnd { get; set; } = new AttributeChoice(AttributeChoice.Choice.BOOL, (int)AttributeChoice.Choice.BOOL | (int)AttributeChoice.Choice.EXPRESSION | (int)AttributeChoice.Choice.VARIABLE_SOURCE);
}