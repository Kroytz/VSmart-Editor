using ImGuiNET;
using System.Reflection;

namespace VSmart_Editor.Types
{
	public class AttributeList<T> : SmartProperty, IVSmartSerializer, IVariableReferenceFixup
	{
		Dictionary<string, object> deleteObjectPairs = new Dictionary<string, object>();
		Dictionary<T, float> objectOrderPairs = new();
		List<T> deleteQueue = new();
		public List<T> InternalList { get; set; } = new();
		public string GetMembersAsString()
		{
			throw new NotImplementedException();
		}

		public string GetModifiersAsString()
		{
			throw new NotImplementedException();
		}

		void SelectorCallback(object value)
		{
			InternalList.Add((T)value);
		}

		public override void Render(string DisplayName = "", string NameInVsmart = "")
		{
			if (ImGui.CollapsingHeader($"{DisplayName}##{GetHashCode()}"))
			{
				if (ImGui.Button($"Add##{GetHashCode()}"))
				{
					var selector = new ObjectSelector(typeof(T), SelectorCallback);
				}

				foreach (var item in deleteQueue)
				{
					InternalList.Remove(item);
				}

				deleteQueue.Clear();
				deleteObjectPairs.Clear();
				objectOrderPairs.Clear();
				float index = 0f;

				foreach (var item in InternalList)
				{
					if (item is null)
						continue;

					index++;
					objectOrderPairs.Add(item, index);


					ImGui.Separator();
					if (ImGui.Button($"^##{item.GetHashCode()}"))
					{
						objectOrderPairs[item] -= 1.5f;
					}
					ImGui.SameLine();
					if (ImGui.Button($"v##{item.GetHashCode()}"))
					{
						objectOrderPairs[item] += 1.5f;
						Console.WriteLine($"Index is {objectOrderPairs[item]}");
					}

					ImGui.SameLine();
					ImGui.Text($"#{objectOrderPairs[item]} - {item.GetType().Name}");

					if (Session.Instance.ShowDebugInfo)
						ImGui.Text($"Hash: {item.GetHashCode()}");

					var label = $"Delete!##{item.GetHashCode()}";
					deleteObjectPairs.Add(label, item);
					if (ImGui.Button(label))
					{
						deleteQueue.Add(item);
					}

					if (ImGui.TreeNode($"Properties##{item.GetHashCode()}"))
					{
						RenderProperties(item);
						ImGui.TreePop();
					}
				}

				var list = InternalList.OrderBy(e => objectOrderPairs[e]);
				foreach (var item in list)
				{
					InternalList.Remove(item);
					InternalList.Add(item);
				}
			}

		}
		void RenderProperties(object item)
		{
			PropertyInfo[] properties = item.GetType().GetProperties();
			foreach (var property in properties)
			{
				var attribute = property.GetCustomAttribute(typeof(SmartPropertyAttribute)) as SmartPropertyAttribute;
				if (attribute == null)
					continue;

				(property.GetValue(item) as SmartProperty).Render(attribute.DisplayName, attribute.NameInVsmart);
				ImGui.Separator();
			}
		}

		public string Serialize()
		{
			string buffer = "";
			buffer += "\n[\n";

			buffer += Serializer.Serialize(this);

			foreach (var item in InternalList)
			{
				buffer += "\n{\n";
				foreach (var property in Serializer.GetProperties(item))
				{
					buffer += Serializer.SerializeProperty(property, item);
				}
				buffer += "\n},\n";
			}
			buffer += "\n]\n";

			return buffer;
		}

		public void Fixup()
		{
			foreach (var item in InternalList)
			{
				Hierarchy.RetargetVariableSources(item);
			}
		}
	}
}
