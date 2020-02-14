using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class FengdieActivitySchemaModel : AopObject
	{
		[XmlElement("schema_data")]
		public string SchemaData
		{
			get;
			set;
		}

		[XmlElement("schema_path")]
		public string SchemaPath
		{
			get;
			set;
		}
	}
}
