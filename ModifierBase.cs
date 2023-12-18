using System.Text.Json.Serialization;
using VSmart_Editor.Types;

namespace VSmart_Editor.Modifiers
{
	[JsonDerivedType(typeof(ModifierBase), "base")]
	[JsonDerivedType(typeof(FilterExpression), "filter_expression")]
	[JsonDerivedType(typeof(FilterProbability), "filter_probability")]
	[JsonDerivedType(typeof(FilterSurfaceAngle), "filter_surface_angle")]
	[JsonDerivedType(typeof(FilterSurfaceProperties), "filter_surface_properties")]
	[JsonDerivedType(typeof(FilterVariableValue), "filter_var_value")]
	[JsonDerivedType(typeof(ModifierCreateLocator), "create_locator")]
	[JsonDerivedType(typeof(ModifierCreateRotator), "create_rotator")]
	[JsonDerivedType(typeof(ModifierCreateSizer), "create_sizer")]
	[JsonDerivedType(typeof(ModifierRandomRotate), "random_rotate")]
	[JsonDerivedType(typeof(ModifierRandomScale), "random_scale")]
	[JsonDerivedType(typeof(ModifierRandomTranslate), "random_translate")]
	[JsonDerivedType(typeof(ModifierRotate), "rotate")]
	[JsonDerivedType(typeof(ModifierScale), "scale")]
	[JsonDerivedType(typeof(ModifierSetTintColor), "set_tint_color")]
	[JsonDerivedType(typeof(ModifierTranslate), "translate")]
	[HideInObjectPicker]
	public class ModifierBase
	{
		[SmartProperty("Class", "_class")] public virtual AttributeString ClassName => new AttributeString("BaseModifier");
		public ModifierBase() { }
	}
}
