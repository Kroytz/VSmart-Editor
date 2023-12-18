using ImGuiNET;
using VSmart_Editor.Variables;

namespace VSmart_Editor.Types
{
	public class AttributeVariableSource : SmartProperty, IVSmartSerializer, IVariableReferenceFixup
	{
		public SmartPropVariable VariableSource { get; set; }

		public void Fixup()
		{
			Console.WriteLine($"Finding match for {VariableSource.VariableName}");
			if (VariableSource == null)
				return;

			foreach (var variable in Session.Instance.Root.Variables.InternalList)
			{
				if (VariableSource.ID == variable.ID)
					VariableSource = variable;
			}
		}

		public string GetMembersAsString()
		{
			throw new NotImplementedException();
		}

		public string GetModifiersAsString()
		{
			throw new NotImplementedException();
		}

		public override void Render(string DisplayName = "", string NameInVsmart = "")
		{
			ImGui.Text(DisplayName);
			if (!Session.Instance.Root.Variables.InternalList.Any())
			{
				ImGui.Text("No Variables Within Vsmart!");
				if (ImGui.Button("Go to Root"))
				{
					Inspector.Select(Session.Instance.Root);
					Console.WriteLine("cliuck");
				}
				return;
			}

			VariableSource ??= Session.Instance.Root.Variables.InternalList.First();

			if (VariableSource is null)
				return;

			if (ImGui.BeginCombo($"##{GetHashCode()}", VariableSource.VariableName.Value))
			{
				foreach (var variable in Session.Instance.Root.Variables.InternalList)
				{
					if (ImGui.Button(variable.VariableName.Value))
					{
						VariableSource = variable;
					}
				}
				ImGui.EndCombo();
			}
		}

		public string Serialize()
		{
			if (VariableSource is null)
				return "variable null error";

			return $"{{ m_SourceName = \"{VariableSource.VariableName.Value}\"}}";
		}
	}
}
