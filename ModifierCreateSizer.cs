using VSmart_Editor.Types;

namespace VSmart_Editor.Modifiers
{
	public class ModifierCreateSizer : ModifierBase
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropOperation_CreateSizer");
		[SmartProperty("Initial Min X", "m_flInitialMinX")]
		public AttributeFloat InitialMinX { get; set; } = new AttributeFloat();
		[SmartProperty("Initial Max X", "m_flInitialMaxX")]
		public AttributeFloat InitialMaxX { get; set; } = new AttributeFloat();
		[SmartProperty("Constraint Min X", "m_flConstraintMinX")]
		public AttributeChoice ConstraintMinX { get; set; } = new(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Constraint Max X", "m_flConstraintMaxX")]
		public AttributeChoice ConstraintMaxX { get; set; } = new(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Output Min X", "m_OutputVariableMinX")]
		public AttributeChoice OutputMinX { get; set; } = new(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.DEFAULT | (int)AttributeChoice.Choice.VARIABLE_NAME | (int)AttributeChoice.Choice.EXPRESSION);
		[SmartProperty("Output Max X", "m_OutputVariableMaxX")]
		public AttributeChoice OutputMaxX { get; set; } = new(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.DEFAULT | (int)AttributeChoice.Choice.VARIABLE_NAME | (int)AttributeChoice.Choice.EXPRESSION);
		[SmartProperty("Initial Min Y", "m_flInitialMinY")]
		public AttributeFloat InitialMinY { get; set; } = new AttributeFloat();
		[SmartProperty("Initial Max Y", "m_flInitialMaxY")]
		public AttributeFloat InitialMaxY { get; set; } = new AttributeFloat();
		[SmartProperty("Constraint Min Y", "m_flConstraintMinY")]
		public AttributeChoice ConstraintMinY { get; set; } = new(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Constraint Max Y", "m_flConstraintMaxY")]
		public AttributeChoice ConstraintMaxY { get; set; } = new(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Output Min Y", "m_OutputVariableMinY")]
		public AttributeChoice OutputMinY { get; set; } = new(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.DEFAULT | (int)AttributeChoice.Choice.VARIABLE_NAME | (int)AttributeChoice.Choice.EXPRESSION);
		[SmartProperty("Output Max Y", "m_OutputVariableMaxY")]
		public AttributeChoice OutputMaxY { get; set; } = new(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.DEFAULT | (int)AttributeChoice.Choice.VARIABLE_NAME | (int)AttributeChoice.Choice.EXPRESSION);
		[SmartProperty("Initial Min Z", "m_flInitialMinZ")]
		public AttributeFloat InitialMinZ { get; set; } = new AttributeFloat();
		[SmartProperty("Initial Max Z", "m_flInitialMaxZ")]
		public AttributeFloat InitialMaxZ { get; set; } = new AttributeFloat();
		[SmartProperty("Constraint Min Z", "m_flConstraintMinZ")]
		public AttributeChoice ConstraintMinZ { get; set; } = new(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Constraint Max Z", "m_flConstraintMaxZ")]
		public AttributeChoice ConstraintMaxZ { get; set; } = new(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.COMMON);
		[SmartProperty("Output Min Z", "m_OutputVariableMinZ")]
		public AttributeChoice OutputMinZ { get; set; } = new(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.DEFAULT | (int)AttributeChoice.Choice.VARIABLE_NAME | (int)AttributeChoice.Choice.EXPRESSION);
		[SmartProperty("Output Max Z", "m_OutputVariableMaxZ")]
		public AttributeChoice OutputMaxZ { get; set; } = new(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.DEFAULT | (int)AttributeChoice.Choice.VARIABLE_NAME | (int)AttributeChoice.Choice.EXPRESSION);

	}
}
