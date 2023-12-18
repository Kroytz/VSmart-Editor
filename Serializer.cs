using System.Reflection;
using VSmart_Editor.Types;

namespace VSmart_Editor
{
	class Serializer
	{
		public static string SerializeMain(object data)
		{
			string buffer = "";
			buffer += "<!-- kv3 encoding:text:version{e21c7f3c-8a33-41c5-9977-a76d3a32aa0d} format:vrfunknown:version{5ab656f0-06de-478a-804e-489e82994fb5} -->";
			buffer += "\n{\n";
			buffer += "\n//Generated from Gunnar Kafel's Smart Prop Creator";
			buffer += "\n//My links:";
			buffer += "\n//paypal.me/gkaf";
			buffer += "\n//twitter.com/gunnarkafel";
			buffer += "\n//gkaf.me";
			buffer += "\n//\n";
			// Gkafscii art
			buffer += "//  ▄████  ██ ▄█▀▄▄▄        █████▒       ██▒   █▓  ██████  ███▄ ▄███▓ ▄▄▄       ██▀███  ▄▄▄█████▓\r\n// ██▒ ▀█▒ ██▄█▒▒████▄    ▓██   ▒       ▓██░   █▒▒██    ▒ ▓██▒▀█▀ ██▒▒████▄    ▓██ ▒ ██▒▓  ██▒ ▓▒\r\n//▒██░▄▄▄░▓███▄░▒██  ▀█▄  ▒████ ░        ▓██  █▒░░ ▓██▄   ▓██    ▓██░▒██  ▀█▄  ▓██ ░▄█ ▒▒ ▓██░ ▒░\r\n//░▓█  ██▓▓██ █▄░██▄▄▄▄██ ░▓█▒  ░         ▒██ █░░  ▒   ██▒▒██    ▒██ ░██▄▄▄▄██ ▒██▀▀█▄  ░ ▓██▓ ░ \r\n//░▒▓███▀▒▒██▒ █▄▓█   ▓██▒░▒█░             ▒▀█░  ▒██████▒▒▒██▒   ░██▒ ▓█   ▓██▒░██▓ ▒██▒  ▒██▒ ░ \r\n// ░▒   ▒ ▒ ▒▒ ▓▒▒▒   ▓▒█░ ▒ ░             ░ ▐░  ▒ ▒▓▒ ▒ ░░ ▒░   ░  ░ ▒▒   ▓▒█░░ ▒▓ ░▒▓░  ▒ ░░   \r\n//  ░   ░ ░ ░▒ ▒░ ▒   ▒▒ ░ ░               ░ ░░  ░ ░▒  ░ ░░  ░      ░  ▒   ▒▒ ░  ░▒ ░ ▒░    ░    \r\n//░ ░   ░ ░ ░░ ░  ░   ▒    ░ ░               ░░  ░  ░  ░  ░      ░     ░   ▒     ░░   ░   ░      \r\n//      ░ ░  ░        ░  ░                    ░        ░         ░         ░  ░   ░              ";
			buffer += "\n";

			buffer += Serialize(data);

			buffer += "}";

			return buffer;
		}
		public static string Serialize(object data)
		{
			var buffer = "";
			var properties = GetProperties(data);
			foreach (var property in properties)
			{
				buffer += SerializeProperty(property, data);
			}

			return buffer;
		}

		public static string SerializeProperty(PropertyInfo property, object data)
		{
			string buffer = "";


			var smartAttribute = property.GetCustomAttribute(typeof(SmartPropertyAttribute)) as SmartPropertyAttribute;
			if (smartAttribute == null)
				return buffer;

			//Hacky hackity hack to skip Skip attributes Skipidi
			if ((property.GetValue(data) is AttributeSkip))
			{
				return "";
			}
			if ((property.GetValue(data) is AttributeChoice choice))
			{
				if (choice.ChildProperty is AttributeSkip)
					return "";
			}

			buffer += $"{smartAttribute.NameInVsmart} = ";

			var serializer = property.GetValue(data) as IVSmartSerializer;
			buffer += Serialize(property.GetValue(data));

			if (serializer == null)
				return buffer;
			buffer += serializer.Serialize();
			buffer += "\n";

			Console.WriteLine(buffer);
			return buffer;
		}

		public static List<PropertyInfo> GetProperties(object data)
		{

			List<PropertyInfo> propertyList = new();
			if (data is null)
				return propertyList;

			PropertyInfo[] properties = data.GetType().GetProperties();
			foreach (var property in properties)
			{
				var hideAttribute = property.GetCustomAttribute(typeof(IgnoreSerializerAttribute)) as IgnoreSerializerAttribute;
				if (hideAttribute != null)
					continue;

				var attribute = property.GetCustomAttribute(typeof(SmartPropertyAttribute)) as SmartPropertyAttribute;
				if (attribute == null)
					continue;

				propertyList.Add(property);
			}

			return propertyList;
		}
	}
}
