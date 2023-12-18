using System.Text.Json.Serialization;
using VSmart_Editor.Types;

namespace VSmart_Editor.Criteria
{
	[JsonDerivedType(typeof(CriteriaBase), "base")]
	[JsonDerivedType(typeof(CriteriaChoiceWeight), "choice_weight")]
	[JsonDerivedType(typeof(CriteriaEndCap), "end_cap")]
	[JsonDerivedType(typeof(CriteriaIsValid), "is_valid")]
	[JsonDerivedType(typeof(CriteriaLinearLength), "linear_length")]
	[JsonDerivedType(typeof(CriteriaPathPositions), "path_positions")]
	[HideInObjectPicker]
	public class CriteriaBase : SmartPropBase
	{
		[SmartProperty("Class", "_class")]
		public virtual AttributeString ClassName => new AttributeString("");

		public CriteriaBase()
		{

		}

		public string GetMembersAsString()
		{
			return $"_class = \"{ClassName}\"";
		}

		public string GetModifiersAsString()
		{
			return "";
		}

		public string Serialize()
		{
			return "";
		}
	}
}
