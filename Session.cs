using System.Text.Json;
using System.Text.Json.Serialization;
using VSmart_Editor.Elements;

namespace VSmart_Editor
{
	public class Session
	{
		public static Session Instance;
		[JsonIgnore] public static string ProjectFileExtension => "smartproj";
		[JsonIgnore] public string CurrentProjectFile { get; set; }
		[JsonIgnore] public bool ShowDebugInfo = false;
		public SmartPropRoot Root { get; set; }
		public Session()
		{
			Instance = this;
			Root = new();
		}

		public void New()
		{
			var session = new Session();
			Inspector.Select(session.Root);
		}

		public void ReloadFromDisk()
		{
			LoadCallback(CurrentProjectFile);
		}

		void LoadCallback(string filePath)
		{
			var options = new JsonSerializerOptions();
			options.ReferenceHandler = ReferenceHandler.Preserve;

			if (!File.Exists(filePath))
				return;

			var data = File.ReadAllText(filePath);
			var session = JsonSerializer.Deserialize<Session>(data, options);

			if (session == null)
				return;

			session.CurrentProjectFile = filePath;
			Inspector.Select(session.Root);
			Instance = session;
		}


		public void Load()
		{
			string[] files = { ProjectFileExtension };
			var dialog = new FileDialog("Open", LoadCallback, files);
		}
		public void Save(string filePath)
		{
			if (!File.Exists(filePath))
			{
				SaveAs();
				return;
			}

			var options = new JsonSerializerOptions();
			options.ReferenceHandler = ReferenceHandler.Preserve;

			var data = JsonSerializer.Serialize(Instance, options);
			File.WriteAllText(filePath, data);
			CurrentProjectFile = filePath;
		}

		void SaveAsCallback(string path)
		{
			var dirIndex = path.LastIndexOf("\\");
			var directory = path.Substring(0, dirIndex);
			if (!Directory.Exists(directory))
				return;

			File.WriteAllText(path, "");
			Save(path);
		}

		public void SaveAs()
		{
			string[] files = { ProjectFileExtension };
			var dialog = new FileDialog("Save", SaveAsCallback, files);
		}
	}
}
