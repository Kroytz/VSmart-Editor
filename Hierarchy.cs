using ImGuiNET;
using System.Text.Json;
using System.Text.Json.Serialization;
using VSmart_Editor.Elements;
using VSmart_Editor.Types;
using VSmart_Editor.Variables;

namespace VSmart_Editor
{
	public class Hierarchy
	{
		public static Hierarchy Instance;
		string copyBuffer = "";
		public Hierarchy()
		{
			Instance = this;
		}

		void AddCallback(object value)
		{
			var target = Inspector.Instance.Target as SmartPropElement;
			target.AddChild((SmartPropElement)value);
		}

		void Copy()
		{
			var target = Inspector.Instance.Target as SmartPropElement;


			//Never copy the root
			if (target is SmartPropRoot)
				return;

			var options = new JsonSerializerOptions();
			options.ReferenceHandler = ReferenceHandler.Preserve;

			var data = JsonSerializer.Serialize(target, options);
			copyBuffer = data;
		}

		void Paste()
		{
			if (copyBuffer == "")
				return;

			var options = new JsonSerializerOptions();
			options.ReferenceHandler = ReferenceHandler.Preserve;
			var element = JsonSerializer.Deserialize<SmartPropElement>(copyBuffer, options);
			Console.WriteLine(copyBuffer);
			Console.WriteLine("\n\n\n");

			RetargetVariableSources(element);

			var target = Inspector.Instance.Target as SmartPropElement;
			target.AddChild(element);
		}

		public static void RetargetVariableSources(object element)
		{
			Console.WriteLine($"Retargeting variables for {element}");
			var properties = element.GetType().GetProperties();
			foreach (var item in properties)
			{
				if (item.PropertyType.BaseType != typeof(SmartProperty) && item.PropertyType != typeof(SmartProperty))
					continue;

				Console.WriteLine($"Retargeting property {item.Name}");

				if (item.GetIndexParameters().Length > 0)
					continue;

				var value = item.GetValue(element);
				if (value == null)
					continue;

				if (value is not IVariableReferenceFixup fixup)
				{
					RetargetVariableSources(value);
					continue;
				}

				Console.WriteLine($"Fixing up {item.Name}");
				fixup.Fixup();
			}
		}

		SmartPropVariable GetMatchingVariable(SmartPropVariable variable)
		{
			if (variable is null)
				return null;

			Console.WriteLine($"Matching variable {variable.VariableName.Value}...");
			var rootVariables = Session.Instance.Root.Variables.InternalList;
			foreach (var item in rootVariables)
			{
				if (item.ID == variable.ID)
				{
					Console.WriteLine($"Matched variable!");
					return item;
				}
			}

			return null;
		}


		public void Render()
		{
			if (ImGui.Button($"Add##{GetHashCode()}"))
			{
				new ObjectSelector(typeof(SmartPropElement), AddCallback);
			}

			ImGui.SameLine();
			if (ImGui.Button($"Copy##{GetHashCode()}"))
			{
				Copy();
			}

			ImGui.SameLine();
			if (ImGui.Button($"Paste##{GetHashCode()}"))
			{
				Paste();
			}

			ImGui.SameLine();
			if (ImGui.Button($"Delete##{GetHashCode()}"))
			{
				var target = Inspector.Instance.Target as SmartPropElement;
				if (target is SmartPropRoot)
					return;
				var parent = target.Parent;
				parent.Children.InternalList.Remove(target);
				Inspector.Instance.Target = parent;
			}
			BuildTree();
		}
		public void BuildTree()
		{
			var label = $"Root | {Session.Instance.Root.Label.Value}";
			var open = ImGui.TreeNodeEx(label, ImGuiTreeNodeFlags.OpenOnArrow | ImGuiTreeNodeFlags.NoTreePushOnOpen | ImGuiTreeNodeFlags.FramePadding | ImGuiTreeNodeFlags.DefaultOpen | ImGuiTreeNodeFlags.SpanFullWidth);
			if (ImGui.IsItemClicked())
			{
				Inspector.Select(Session.Instance.Root);

			}

			if (open)
			{
				AddChildren(Session.Instance.Root);
				ImGui.TreePop();
			}

		}

		void AddChildren(SmartPropElement element)
		{
			foreach (var child in element.Children.InternalList)
			{
				//Make our pretty label with a unique hash
				var label = $"{child.DisplayName} | {child.Label.Value}##{child.GetHashCode()}";
				var open = ImGui.TreeNodeEx($"{label}##{child.GetHashCode()}", ImGuiTreeNodeFlags.OpenOnArrow | ImGuiTreeNodeFlags.FramePadding | ImGuiTreeNodeFlags.DefaultOpen | ImGuiTreeNodeFlags.SpanFullWidth);
				if (ImGui.IsItemClicked())
					Inspector.Select(child);

				if (open)
				{
					AddChildren(child);
					ImGui.TreePop();
				}
			}
		}
	}
}
