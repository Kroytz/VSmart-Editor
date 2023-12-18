using ClickableTransparentOverlay;
using ImGuiNET;
using System.Diagnostics;
using System.Numerics;

namespace VSmart_Editor;

public class Program : Overlay
{
	public override Task Run()
	{
		ImGui.SetWindowSize(new Vector2(2, 2));
		return base.Run();
	}
	string LastExportedPath = string.Empty;
	protected override void Render()
	{
		if (ImGui.BeginMainMenuBar())
		{
			if (ImGui.BeginMenu("File"))
			{
				if (ImGui.Button("New"))
				{
					Session.Instance.New();
				}
				if (ImGui.Button("Open"))
				{
					Session.Instance.Load();
				}
				if (ImGui.Button("Reload From Disk"))
				{
					Session.Instance.ReloadFromDisk();
				}
				if (ImGui.Button("Save"))
				{
					Session.Instance.Save(Session.Instance.CurrentProjectFile);
				}
				if (ImGui.Button("Save As"))
				{
					Session.Instance.SaveAs();
				}
				ImGui.EndMenu();
			}

			if (ImGui.BeginMenu("Export"))
			{
				if (ImGui.Button("Export as vsmart"))
				{
					string[] files = { "vsmart" };
					var dialog = new FileDialog("Export", ExportToVsmart, files);
				}

				if (LastExportedPath != string.Empty && ImGui.Button("Rexport"))
				{
					ExportToVsmart(LastExportedPath);
				}

				ImGui.EndMenu();
			}

			if (ImGui.BeginMenu("Debug"))
			{
				ImGui.Checkbox("Show Debug Info", ref Session.Instance.ShowDebugInfo);

				ImGui.EndMenu();
			}

			if (ImGui.BeginMenu("Help"))
			{
				if (ImGui.Button("Documentation"))
				{
					var psi = new ProcessStartInfo()
					{
						FileName = "https://developer.valvesoftware.com/wiki/Counter-Strike_2_Workshop_Tools/Level_Design/Smartprops",
						UseShellExecute = true,
					};
					Process.Start(psi);
				}

				ImGui.EndMenu();
			}

			string titleText = $"{Session.Instance.CurrentProjectFile}";
			var nameIndex = titleText.LastIndexOf("\\");

			if (nameIndex >= 0 && (nameIndex + 1) < titleText.Length)
				titleText = titleText.Substring(nameIndex + 1);

			var windowWidth = ImGui.GetWindowWidth();
			var textWidth = ImGui.CalcTextSize(titleText);
			ImGui.SetCursorPosX((windowWidth - textWidth.X) / 2);
			ImGui.Text(titleText);

			var closeWidth = ImGui.CalcTextSize("X");
			ImGui.SetCursorPosX(windowWidth - closeWidth.X * 3);
			if (ImGui.Button("X"))
			{
				System.Environment.Exit(0);
			}

			ImGui.EndMainMenuBar();
		}

		ImGui.Begin("Inspector");
		Inspector.Instance.Render();
		ImGui.End();

		ImGui.Begin("Hierarchy");
		Hierarchy.Instance.Render();
		ImGui.End();

		if (ObjectSelector.Instance is not null)
			ObjectSelector.Instance.Render();

		if (FileDialog.Instance is not null)
			FileDialog.Instance.Render();

		if (Session.Instance.ShowDebugInfo)
		{
			ImGui.Begin("Debug");
			if (ImGui.CollapsingHeader("Output"))
			{
				var serializedData = Serializer.SerializeMain(Session.Instance.Root);
				ImGui.InputTextMultiline("", ref serializedData, 18192, new Vector2(800, 800));
			}
			ImGui.End();
		}

	}

	void ExportToVsmart(string filePath)
	{
		LastExportedPath = filePath;
		var data = Serializer.SerializeMain(Session.Instance.Root);
		File.WriteAllText(filePath, data);
	}

	public static void Main(string[] args)
	{
		Program program = new Program();
		Session session = new Session();
		Inspector inspector = new Inspector();
		Hierarchy hierarchy = new Hierarchy();

		program.Start().Wait();
	}
}