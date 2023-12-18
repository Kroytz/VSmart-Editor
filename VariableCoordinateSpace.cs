using VSmart_Editor.Types;

namespace VSmart_Editor.Variables
{
	public class VariableCoordinateSpace : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_CoordinateSpace");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.COORDINATE_SPACE, (int)AttributeChoice.Choice.COORDINATE_SPACE);
	}
	public class VariableDirection : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_Direction");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.DIRECTION, (int)AttributeChoice.Choice.DIRECTION);
	}
	public class VariableDistributionMode : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_DistributionMode");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.DISTRIBUTION_MODE, (int)AttributeChoice.Choice.DISTRIBUTION_MODE);
	}
	public class VariableRadiusPlacementMode : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_RadiusPlacementMode");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.RADIUS_PLACEMENT_MODE, (int)AttributeChoice.Choice.RADIUS_PLACEMENT_MODE);
	}
	public class VariableChoiceSelectionMode : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_ChoiceSelectionMode");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.CHOICE_SELECTION_MODE, (int)AttributeChoice.Choice.CHOICE_SELECTION_MODE);
	}
	public class VariableString : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_String");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.STRING, (int)AttributeChoice.Choice.STRING);
	}
	public class VariableBool : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_Bool");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.BOOL, (int)AttributeChoice.Choice.BOOL);
	}
	public class VariableInt : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_Int");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.INT, (int)AttributeChoice.Choice.INT);
		[SmartProperty("Min Value", "m_nParamaterMinValue")]
		public AttributeChoice MinValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.INT | (int)AttributeChoice.Choice.DEFAULT);
		[SmartProperty("Max Value", "m_nParamaterMaxValue")]
		public AttributeChoice MaxValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.INT | (int)AttributeChoice.Choice.DEFAULT);
	}
	public class VariableFloat : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_Float");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.FLOAT, (int)AttributeChoice.Choice.FLOAT);
		[SmartProperty("Min Value", "m_flParamaterMinValue")]
		public AttributeChoice MinValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.DEFAULT);
		[SmartProperty("Max Value", "m_flParamaterMaxValue")]
		public AttributeChoice MaxValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.DEFAULT, (int)AttributeChoice.Choice.FLOAT | (int)AttributeChoice.Choice.DEFAULT);
	}
	public class VariableVector2D : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_Vector2D");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeVector2D DefaultValue { get; set; } = new AttributeVector2D() { SimpleSerialize = true };
	}
	public class VariableVector3D : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_Vector3D");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeVector3D DefaultValue { get; set; } = new AttributeVector3D() { SimpleSerialize = true };
	}
	public class VariableVector4D : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_Vector4D");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeVector4D DefaultValue { get; set; } = new AttributeVector4D() { SimpleSerialize = true };
	}
	public class VariableColor : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_Color");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.COLOR, (int)AttributeChoice.Choice.COLOR);
	}
	public class VariableAngles : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_Angles");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.VECTOR3D, (int)AttributeChoice.Choice.VECTOR3D);
	}
	public class VariableMaterialGroup : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_MaterialGroup");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.STRING, (int)AttributeChoice.Choice.STRING);
		[SmartProperty("Model Name", "m_sModelName")]
		public AttributeString ModelName { get; set; } = new();
	}
	public class VariableModel : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_Model");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.STRING, (int)AttributeChoice.Choice.STRING);
	}
	public class VariableApplyColorMode : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_ApplyColorMode");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.APPLY_COLOR_MODE, (int)AttributeChoice.Choice.APPLY_COLOR_MODE);
	}
	public class VariableTraceNoHit : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_TraceNoHit");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.TRACE_NO_HIT, (int)AttributeChoice.Choice.TRACE_NO_HIT);
	}
	public class VariableScaleMode : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_ScaleMode");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.SCALE_MODE, (int)AttributeChoice.Choice.SCALE_MODE);
	}
	public class VariablePickMode : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_PickMode");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.PICK_MODE, (int)AttributeChoice.Choice.PICK_MODE);
	}
	public class VariableGridPlacementMode : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_GridPlacementMode");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.GRID_PLACEMENT_MODE, (int)AttributeChoice.Choice.GRID_PLACEMENT_MODE);
	}
	public class VariableGridOriginMode : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_GridOriginMode");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.GRID_ORIGIN_MODE, (int)AttributeChoice.Choice.GRID_ORIGIN_MODE);
	}
	public class VariablePathPositions : SmartPropVariable
	{
		public override AttributeString ClassName => new AttributeString("CSmartPropVariable_GridOriginMode");
		[SmartProperty("Default Value", "m_DefaultValue")]
		public AttributeChoice DefaultValue { get; set; } = new AttributeChoice(AttributeChoice.Choice.PATH_POSITIONS, (int)AttributeChoice.Choice.PATH_POSITIONS);
	}
}
