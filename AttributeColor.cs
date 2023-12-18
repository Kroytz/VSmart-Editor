using ImGuiNET;
using System.Numerics;

namespace VSmart_Editor.Types
{
	public class AttributeColor : SmartProperty, IVSmartSerializer
	{
		public float r { get; set; } = 0f;
		public float g { get; set; } = 0f;
		public float b { get; set; } = 0f;
		public override void Render(string DisplayName = "", string NameInVsmart = "")
		{
			ImGui.Text(DisplayName);
			var color = new Vector3(r, g, b);
			ImGui.ColorPicker3("", ref color);
			r = color.X;
			g = color.Y;
			b = color.Z;
		}

		public string Serialize()
		{
			var outputColor = new Vector3(r, g, b) * 255;
			return $"[{(int)outputColor.X}, {(int)outputColor.Y}, {(int)outputColor.Z}]";
		}
	}
}
