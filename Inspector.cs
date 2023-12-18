using ImGuiNET;
using System.Reflection;
using VSmart_Editor.Types;

namespace VSmart_Editor
{
	public class Inspector
	{
		public static Inspector Instance;
		public object Target = Session.Instance.Root;
		public object QueuedTarget = Session.Instance.Root;
		public Inspector()
		{
			Instance = this;
		}

		public static void Select(object value)
		{
			Instance.QueuedTarget = value;
		}

		public void Render()
		{
			Target = QueuedTarget;
			if (Target is null)
				return;

			PropertyInfo[] properties = Target.GetType().GetProperties();
			foreach (var property in properties)
			{
				var hideAttribute = property.GetCustomAttribute(typeof(HidePropertyAttribute)) as HidePropertyAttribute;
				if (hideAttribute != null)
					continue;

				var attribute = property.GetCustomAttribute(typeof(SmartPropertyAttribute)) as SmartPropertyAttribute;
				if (attribute == null)
					continue;

				if (property.GetValue(Target) == null)
					continue;

				(property.GetValue(Target) as SmartProperty).Render(attribute.DisplayName, attribute.NameInVsmart);
				ImGui.Separator();
			}
		}
	}
}
