using System.Text.Json.Serialization;
using VSmart_Editor.Types;

namespace VSmart_Editor.Variables
{
	[JsonDerivedType(typeof(SmartPropVariable), "base")]
	[JsonDerivedType(typeof(VariableAngles), "angles")]
	[JsonDerivedType(typeof(VariableApplyColorMode), "apply_color_mode")]
	[JsonDerivedType(typeof(VariableBool), "bool")]
	[JsonDerivedType(typeof(VariableChoiceSelectionMode), "choice_selection_mode")]
	[JsonDerivedType(typeof(VariableColor), "color")]
	[JsonDerivedType(typeof(VariableCoordinateSpace), "coordinate_space")]
	[JsonDerivedType(typeof(VariableDirection), "direction")]
	[JsonDerivedType(typeof(VariableDistributionMode), "distribution_mode")]
	[JsonDerivedType(typeof(VariableFloat), "float")]
	[JsonDerivedType(typeof(VariableGridOriginMode), "grid_origin_mode")]
	[JsonDerivedType(typeof(VariableGridPlacementMode), "grid_placement_mode")]
	[JsonDerivedType(typeof(VariableInt), "int")]
	[JsonDerivedType(typeof(VariableMaterialGroup), "material_group")]
	[JsonDerivedType(typeof(VariableModel), "model")]
	[JsonDerivedType(typeof(VariablePathPositions), "path_positions")]
	[JsonDerivedType(typeof(VariablePickMode), "pick_mode")]
	[JsonDerivedType(typeof(VariableRadiusPlacementMode), "radius_placement_mode")]
	[JsonDerivedType(typeof(VariableScaleMode), "scale_mode")]
	[JsonDerivedType(typeof(VariableString), "string")]
	[JsonDerivedType(typeof(VariableTraceNoHit), "trace_no_hit")]
	[JsonDerivedType(typeof(VariableVector2D), "vector2D")]
	[JsonDerivedType(typeof(VariableVector3D), "vector3D")]
	[JsonDerivedType(typeof(VariableVector4D), "vector4D")]
	[HideInObjectPicker]
	public class SmartPropVariable : SmartPropBase
	{
		[SmartProperty("Class", "_class")]
		public virtual AttributeString ClassName => new AttributeString("BaseVariable");
		[SmartProperty("Variable Name", "m_VariableName")]
		public AttributeString VariableName { get; set; } = new AttributeString();
		[SmartProperty("Display Name", "m_DisplayName")]
		public AttributeString DisplayName { get; set; } = new AttributeString();
		[SmartProperty("Show In Hammer", "m_bExposeAsParameter")]
		public AttributeBool ExposeAsParameter { get; set; } = new AttributeBool();
		public int ID { get; set; } = 0;
		public SmartPropVariable()
		{
			ID = GetHashCode();
		}
	}
}
