using ImGuiNET;
using System.Numerics;

namespace VSmart_Editor
{
	public class FileDialog
	{
		public static FileDialog Instance;
		Vector2 offset => new Vector2(100f, 100f);
		string folderViewTargetDirectory = "";
		string selectedFileName = "";
		Action<string> okCallback;
		string confirmActionLabel;
		string[] fileTypes;
		const float horizontalExplorerSize = 800f;
		const float verticalExplorerSize = 400f;
		public FileDialog(string confirmActionLabel, Action<string> okCallback, string[] fileTypes)
		{
			Instance = this;
			this.okCallback = okCallback;
			this.confirmActionLabel = confirmActionLabel;
			this.fileTypes = fileTypes;
		}
		public void Render()
		{
			ImGui.SetNextWindowSize(new Vector2(horizontalExplorerSize * .5f, verticalExplorerSize));
			ImGui.SetNextWindowPos(new Vector2(0, 0) + offset);
			ImGui.Begin("File Dialog");
			var drives = Directory.GetLogicalDrives();

			foreach (var drive in drives)
			{
				RenderDirectory(drive);
			}
			ImGui.End();

			ImGui.SetNextWindowSize(new Vector2(horizontalExplorerSize * 1.5f, verticalExplorerSize));
			ImGui.SetNextWindowPos(new Vector2(horizontalExplorerSize * .5f, 0) + offset);
			ImGui.Begin("tab");
			RenderFolderView(folderViewTargetDirectory);
			ImGui.End();

			ImGui.SetNextWindowSize(new Vector2(horizontalExplorerSize * 2, 80));
			ImGui.SetNextWindowPos(new Vector2(0, verticalExplorerSize) + offset);
			ImGui.Begin("File");
			ImGui.InputText("", ref selectedFileName, 8192);
			ImGui.SameLine();
			if (ImGui.Button(confirmActionLabel))
			{
				Confirm($"{folderViewTargetDirectory}\\{selectedFileName}");
			}
			ImGui.SameLine();
			if (ImGui.Button("Cancel"))
			{
				Cancel();
			}
			ImGui.End();
		}

		void RenderFolderView(string path)
		{
			if (!Directory.Exists(path))
				return;

			var files = Directory.GetFiles(path);
			foreach (var file in files)
			{
				var fileName = Path.GetFileName(file);
				bool shouldContinue = false;
				foreach (var fileType in fileTypes)
				{
					if (!fileName.EndsWith($".{fileType}"))
						shouldContinue = true;

					Console.WriteLine($"\n{$".{fileType}"} - {fileName} - {shouldContinue}");
				}

				if (shouldContinue)
					continue;

				if (ImGui.Button(fileName))
				{
					selectedFileName = fileName;
				}
			}
		}

		void RenderDirectory(string path)
		{
			var displayLabel = Path.GetFileName(path);
			if (displayLabel == "")
				displayLabel = path;

			bool open = ImGui.TreeNodeEx(displayLabel);
			if (ImGui.IsItemClicked())
			{
				folderViewTargetDirectory = path;
			}

			if (open)
			{
				var subdirectories = Directory.GetDirectories(path);
				foreach (var subdirectory in subdirectories)
				{
					RenderDirectory(subdirectory);
				}
				ImGui.TreePop();
			}
		}

		void Confirm(string output)
		{
			if (fileTypes.Length == 1 && !output.EndsWith($".{fileTypes[0]}"))
			{
				output += $".{fileTypes[0]}";
			}

			okCallback.Invoke(output);
			Instance = null;
		}

		void Cancel()
		{
			Instance = null;
		}
	}
}
