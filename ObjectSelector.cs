using ImGuiNET;
using System.Reflection;

namespace VSmart_Editor
{
	public class ObjectSelector
	{
		public static ObjectSelector Instance;
		public Type TargetType;
		public List<object> TargetList;
		Action<object> callback;
		public ObjectSelector(Type targetType, Action<object> callback)
		{
			Instance = this;
			TargetType = targetType;
			this.callback = callback;
		}

		public void Render()
		{
			Type hoveredType = null;
			ImGui.Begin("Select an object");
			var assembly = Assembly.GetExecutingAssembly();
			var types = assembly.GetTypes().ToList();
			foreach (var type in types)
			{
				if (type == null)
					continue;

				if (type != TargetType && !type.IsSubclassOf(TargetType))
					continue;

				if (type.IsAbstract)
					continue;

				if (type.GetCustomAttribute(typeof(HideInObjectPickerAttribute), false) != null)
					continue;

				if (ImGui.Button($"{type.Name}"))
				{
					var instance = assembly.CreateInstance(type.FullName);
					if (instance is null)
						continue;

					callback.Invoke(instance);
					//Destroy this selector
					Instance = null;

				}

				if (ImGui.IsItemHovered())
				{
					hoveredType = type;
				}
			}

			if (ImGui.BeginTabBar("tooltip"))
			{
				if (hoveredType == null)
				{
					ImGui.EndTabBar();
					return;
				}

				var tipAttribute = hoveredType.GetCustomAttribute(typeof(TooltipAttribute)) as TooltipAttribute;
				if (tipAttribute != null)
				{
					ImGui.Text(tipAttribute.Title);
					ImGui.TextWrapped(tipAttribute.Tooltip);
				}

				ImGui.EndTabBar();
			}



			ImGui.End();
		}
	}
}
