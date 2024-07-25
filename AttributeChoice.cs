using ImGuiNET;

namespace VSmart_Editor.Types
{
	public class AttributeChoice : SmartProperty, IVSmartSerializer
	{
		public Choice SelectedChoice { get; set; }
		public int AllowedChoices { get; set; }
		public SmartProperty ChildProperty { get; set; }


		public AttributeChoice(Choice startingChoice, int whitelist)
		{
			SelectedChoice = startingChoice;
			AllowedChoices = whitelist;
			SelectNewType();
		}

		public override void Render(string DisplayName = "", string NameInVsmart = "")
		{
			ChildProperty.Render(DisplayName);
			ImGui.SameLine();
			ImGui.SetNextItemWidth(144f);
			if (ImGui.BeginCombo($"##{GetHashCode()}", SelectedChoice.ToString()))
			{
				if (((AllowedChoices & (int)Choice.FLOAT) != 0) && ImGui.Button("Float"))
				{
					SelectedChoice = Choice.FLOAT;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.INT) != 0) && ImGui.Button("Int"))
				{
					SelectedChoice = Choice.INT;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.BOOL) != 0) && ImGui.Button("Bool"))
				{
					SelectedChoice = Choice.BOOL;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.STRING) != 0) && ImGui.Button("String"))
				{
					SelectedChoice = Choice.STRING;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.VECTOR2D) != 0) && ImGui.Button("Vector 2D"))
				{
					SelectedChoice = Choice.VECTOR2D;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.VECTOR3D) != 0) && ImGui.Button("Vector 3D"))
				{
					SelectedChoice = Choice.VECTOR3D;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.VECTOR4D) != 0) && ImGui.Button("Vector 4D"))
				{
					SelectedChoice = Choice.VECTOR4D;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.COORDINATE_SPACE) != 0) && ImGui.Button("Coordinate Space"))
				{
					SelectedChoice = Choice.COORDINATE_SPACE;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.DIRECTION) != 0) && ImGui.Button("Direction"))
				{
					SelectedChoice = Choice.DIRECTION;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.DISTRIBUTION_MODE) != 0) && ImGui.Button("Distribution Mode"))
				{
					SelectedChoice = Choice.DISTRIBUTION_MODE;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.RADIUS_PLACEMENT_MODE) != 0) && ImGui.Button("Radius Placement Mode"))
				{
					SelectedChoice = Choice.RADIUS_PLACEMENT_MODE;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.CHOICE_SELECTION_MODE) != 0) && ImGui.Button("Choice Selection Mode"))
				{
					SelectedChoice = Choice.CHOICE_SELECTION_MODE;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.APPLY_COLOR_MODE) != 0) && ImGui.Button("Apply Color Mode"))
				{
					SelectedChoice = Choice.APPLY_COLOR_MODE;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.TRACE_NO_HIT) != 0) && ImGui.Button("Trace No Hit Behavior"))
				{
					SelectedChoice = Choice.TRACE_NO_HIT;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.SCALE_MODE) != 0) && ImGui.Button("Scale Mode"))
				{
					SelectedChoice = Choice.SCALE_MODE;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.PICK_MODE) != 0) && ImGui.Button("Pick Mode"))
				{
					SelectedChoice = Choice.PICK_MODE;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.GRID_PLACEMENT_MODE) != 0) && ImGui.Button("Grid Placement Mode"))
				{
					SelectedChoice = Choice.GRID_PLACEMENT_MODE;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.GRID_ORIGIN_MODE) != 0) && ImGui.Button("Grid Origin Mode"))
				{
					SelectedChoice = Choice.GRID_ORIGIN_MODE;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.PATH_POSITIONS) != 0) && ImGui.Button("Path Positions"))
				{
					SelectedChoice = Choice.PATH_POSITIONS;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.HANDLE_SHAPE) != 0) && ImGui.Button("Handle Shape"))
				{
					SelectedChoice = Choice.HANDLE_SHAPE;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.COLOR) != 0) && ImGui.Button("Color"))
				{
					SelectedChoice = Choice.COLOR;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.VARIABLE_NAME) != 0) && ImGui.Button("Variable Name"))
				{
					SelectedChoice = Choice.VARIABLE_NAME;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.DEFAULT) != 0) && ImGui.Button("Default"))
				{
					SelectedChoice = Choice.DEFAULT;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.VARIABLE_SOURCE) != 0) && ImGui.Button("Variable Source"))
				{
					SelectedChoice = Choice.VARIABLE_SOURCE;
					SelectNewType();
				}

				if (((AllowedChoices & (int)Choice.EXPRESSION) != 0) && ImGui.Button("Expression"))
				{
					SelectedChoice = Choice.EXPRESSION;
					SelectNewType();
				}

				ImGui.EndCombo();
			}
		}

		public string Serialize()
		{
			if (ChildProperty is not IVSmartSerializer serializer)
				return "";

			return serializer.Serialize();
		}

		public string GetSelectedChoice()
		{
			return SelectedChoice.ToString();
		}

		void SelectNewType()
		{
			switch (SelectedChoice)
			{
				case Choice.FLOAT:
					ChildProperty = new AttributeFloat();
					break;
				case Choice.INT:
					ChildProperty = new AttributeFloat();
					break;
				case Choice.BOOL:
					ChildProperty = new AttributeBool();
					break;
				case Choice.STRING:
					ChildProperty = new AttributeString();
					break;
				case Choice.VECTOR2D:
					ChildProperty = new AttributeVector2D();
					break;
				case Choice.VECTOR3D:
					ChildProperty = new AttributeVector3D();
					break;
				case Choice.VECTOR4D:
					ChildProperty = new AttributeVector4D();
					break;
				case Choice.COORDINATE_SPACE:
					string[] spaceChoices = { "ELEMENT", "OBJECT", "WORLD" };
					ChildProperty = new AttributeCombo(spaceChoices);
					break;
				case Choice.DIRECTION:
					ChildProperty = new AttributeVector3D();
					break;
				case Choice.DISTRIBUTION_MODE:
					string[] distributionChoices = { "RANDOM", "REGULAR", };
					ChildProperty = new AttributeCombo(distributionChoices);
					break;
				case Choice.RADIUS_PLACEMENT_MODE:
					string[] radiusChoices = { "SPHERE", "CIRCLE", };
					ChildProperty = new AttributeCombo(radiusChoices);
					break;
				case Choice.CHOICE_SELECTION_MODE:
					string[] choiceChoices = { "RANDOM", "FIRST", };
					ChildProperty = new AttributeCombo(choiceChoices);
					break;
				case Choice.APPLY_COLOR_MODE:
					string[] colorChoices = { "MULTIPLY_OBJECT", "MULTIPLY_CURRENT", "REPLACE", };
					ChildProperty = new AttributeCombo(colorChoices);
					break;
				case Choice.TRACE_NO_HIT:
					string[] traceChoices = { "NOTHING", "DISCARD", "MOVE_TO_START", "MOVE_TO_END", };
					ChildProperty = new AttributeCombo(traceChoices);
					break;
				case Choice.SCALE_MODE:
					string[] scaleChoices = { "NONE", "SCALE_END_TO_FIT", "SCALE_EQUALLY", "SCALE_MAXIMIZE", };
					ChildProperty = new AttributeCombo(scaleChoices);
					break;
				case Choice.PICK_MODE:
					string[] pickChoices = { "LARGEST_FIRST", "RANDOM", "ALL_IN_ORDER", };
					ChildProperty = new AttributeCombo(pickChoices);
					break;
				case Choice.GRID_PLACEMENT_MODE:
					string[] gridPlaceChoices = { "SEGMENT", "FILL", };
					ChildProperty = new AttributeCombo(gridPlaceChoices);
					break;
				case Choice.GRID_ORIGIN_MODE:
					string[] gridOriginChoices = { "CENTER", "CORNER", };
					ChildProperty = new AttributeCombo(gridOriginChoices);
					break;
				case Choice.PATH_POSITIONS:
					string[] pathChoices = { "ALL", "NTH", "START_AND_END", "CONTROL_POINTS" };
					ChildProperty = new AttributeCombo(pathChoices);
					break;
				case Choice.HANDLE_SHAPE:
					string[] shapeChoices = { "SQUARE", "DIAMOND", "CIRCLE", };
					ChildProperty = new AttributeCombo(shapeChoices);
					break;
				case Choice.COLOR:
					ChildProperty = new AttributeColor();
					break;
				case Choice.VARIABLE_NAME:
					ChildProperty = new AttributeVariableNameReference();
					break;
				case Choice.DEFAULT:
					ChildProperty = new AttributeSkip();
					break;
				case Choice.VARIABLE_SOURCE:
					ChildProperty = new AttributeVariableSource();
					break;
				case Choice.EXPRESSION:
					ChildProperty = new AttributeExpression();
					break;
				default:
					break;
			}
		}

		public enum Choice
		{
			NONE = 0,
			FLOAT = 1 << 0,
			INT = 1 << 1,
			BOOL = 1 << 2,
			STRING = 1 << 3,
			VECTOR2D = 1 << 4,
			VECTOR3D = 1 << 5,
			VECTOR4D = 1 << 6,
			COORDINATE_SPACE = 1 << 7,
			DIRECTION = 1 << 8,
			DISTRIBUTION_MODE = 1 << 9,
			RADIUS_PLACEMENT_MODE = 1 << 10,
			CHOICE_SELECTION_MODE = 1 << 11,
			APPLY_COLOR_MODE = 1 << 12,
			TRACE_NO_HIT = 1 << 13,
			SCALE_MODE = 1 << 14,
			PICK_MODE = 1 << 15,
			GRID_PLACEMENT_MODE = 1 << 16,
			GRID_ORIGIN_MODE = 1 << 17,
			PATH_POSITIONS = 1 << 18,
			HANDLE_SHAPE = 1 << 19,
			COLOR = 1 << 20,
			VARIABLE_NAME = 1 << 21,
			DEFAULT = 1 << 22,
			VARIABLE_SOURCE = 1 << 23,
			EXPRESSION = 1 << 24,
			COMMON = DEFAULT | VARIABLE_SOURCE | EXPRESSION,
			ALL = int.MaxValue,
		}
	}
}
