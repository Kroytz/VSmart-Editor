using ClickableTransparentOverlay;
using ImGuiNET;
using System.Diagnostics;
using System.Numerics;
using GLFW;
using System.Windows;
using ValveResourceFormat.Serialization.KeyValues;

namespace VSmart_Editor;


public class Program : Overlay
{
    public static string LastExportedPath = string.Empty;
    private static ImFontPtr font;

    public override Task Run()
    {
        ImGui.SetWindowSize(new Vector2(2, 2));
        return base.Run();
    }


    protected override void Render()
    {
        ImGuiStylePtr style = ImGui.GetStyle();
        style.FrameRounding = 2;

        Vector4 buttonColor = new Vector4(0.3f, 0.3f, 0.3f, 1);
        Vector4 buttonHoverColor = new Vector4(0.2f, 0.6f, 0.4f, 1);
        Vector4 buttonActiveColor = new Vector4(0.5f, 0.7f, 0.5f, 1);

        Vector4 backgroundColor = new Vector4(0.11f, 0.1f, 0.1f, 1f);

        Vector4 miscHoverColor = new Vector4(0.15f, 0.15f, 0.15f, 1f);

        Vector4 textColor = new Vector4(1, 0.95f, 0.85f, 1);

        style.Colors[(int)ImGuiCol.Text] = textColor;
        style.Colors[(int)ImGuiCol.Header] = new Vector4(0.2f, 0.2f, 0.2f, 1);
        style.Colors[(int)ImGuiCol.Border] = new Vector4(0.5f, 0.5f, 0.5f, 0.5f);

        style.Colors[(int)ImGuiCol.Button] = buttonColor;
        style.Colors[(int)ImGuiCol.ButtonHovered] = buttonHoverColor;
        style.Colors[(int)ImGuiCol.ButtonActive] = buttonActiveColor;

        style.Colors[(int)ImGuiCol.TitleBg] = backgroundColor;
        style.Colors[(int)ImGuiCol.TitleBgActive] = miscHoverColor;


        style.Colors[(int)ImGuiCol.Header] = new Vector4(0.40f, 0.42f, 0.42f, 1);
        style.Colors[(int)ImGuiCol.HeaderHovered] = buttonHoverColor;
        style.Colors[(int)ImGuiCol.HeaderActive] = buttonActiveColor;

        style.Colors[(int)ImGuiCol.TabUnfocusedActive] = miscHoverColor;
        style.Colors[(int)ImGuiCol.TabActive] = buttonActiveColor;
        style.Colors[(int)ImGuiCol.TabHovered] = buttonActiveColor;

        style.Colors[(int)ImGuiCol.MenuBarBg] = backgroundColor;
        style.Colors[(int)ImGuiCol.WindowBg] = backgroundColor;
        style.Colors[(int)ImGuiCol.FrameBg] = new Vector4(0.25f, 0.25f, 0.3f, 1f);

        style.Colors[(int)ImGuiCol.Separator] = new Vector4(0.2f, 0.2f, 0.2f, 1f);
        style.Colors[(int)ImGuiCol.ResizeGrip] = new Vector4(0.2f, 0.2f, 0.2f, 1f);
        ReplaceFont("C:\\WINDOWS\\Fonts\\Arial.ttf", 24, FontGlyphRangeType.English);


        /*
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
				*/


        ImGui.Begin("Inspector");
        if (ImGui.Button("QUIT"))
        {
            Environment.Exit(0);
        }
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

    public static void ExportToVsmart(string filePath)
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

        Application.Run(new FormMenu());
    }

    public static void ImportFromVsmart(string filePath)
    {
        // 		fileName	"D:\\test.vsmart"	string
        if (File.Exists(filePath))
        {
            KVObject kv3;
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                try
                {
                    kv3 = KeyValues3.ParseKVFile(fs).Root;
                    System.Console.WriteLine(kv3.ToString());
                    fs.Close();
                }
                catch (System.Exception e)
                {
                    // TODO: Current parser fails when root is "null", so just skip over them for now
                    Console.Error.WriteLine(e.ToString());
                    return;
                }
            }
        }
        else
        {
            System.Console.WriteLine($"File {filePath} not found");
        }
    }
}