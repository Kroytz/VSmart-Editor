using System.Text.Json.Serialization;
using VSmart_Editor.Criteria;
using VSmart_Editor.Modifiers;
using VSmart_Editor.Types;

namespace VSmart_Editor.Elements
{
	[JsonDerivedType(typeof(SmartPropElement), "base")]
	[JsonDerivedType(typeof(SmartPropElementGroup), "group")]
	[JsonDerivedType(typeof(SmartPropElementFitOnLine), "fit_on_line")]
	[JsonDerivedType(typeof(SmartPropElementModel), "model")]
	[JsonDerivedType(typeof(SmartPropElementModifyState), "modify_state")]
	[JsonDerivedType(typeof(SmartPropElementPickOne), "pick_one")]
	[JsonDerivedType(typeof(SmartPropElementPlaceInSphere), "place_in_sphere")]
	[JsonDerivedType(typeof(SmartPropElementPlaceMultiple), "place_multiple")]
	[JsonDerivedType(typeof(SmartPropElementPlaceOnPath), "place_on_path")]
	[JsonDerivedType(typeof(SmartPropElementSmartProp), "smartprop")]
	[JsonDerivedType(typeof(SmartPropRoot), "root")]
	[HideInObjectPicker]
	public class SmartPropElement : SmartPropBase
	{
		[SmartProperty("Class", "_class")]
		public virtual AttributeString ClassName => new AttributeString("BaseElement");
		public virtual string DisplayName => "Abstract Base Element, how did you get here?";
		[SmartProperty("Modifiers", "m_Modifiers")]
		public AttributeList<ModifierBase> Modifiers { get; set; } = new();
		[SmartProperty("Selection Criteria", "m_SelectionCriteria")]
		public AttributeList<CriteriaBase> SelectionCriteria { get; set; } = new();
		[SmartProperty("Children", "m_Children")]
		public AttributeList<SmartPropElement> Children { get; set; } = new();
		public SmartPropElement Parent { get; set; }
		public SmartPropElement() { }

		public void AddChild(SmartPropElement child)
		{
			Children.InternalList.Add(child);
			child.Parent = this;
		}
	}
}
