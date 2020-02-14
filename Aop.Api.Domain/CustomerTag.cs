using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class CustomerTag : AopObject
	{
		[XmlElement("col_name")]
		public string ColName
		{
			get;
			set;
		}

		[XmlElement("column_type")]
		public string ColumnType
		{
			get;
			set;
		}

		[XmlElement("id")]
		public string Id
		{
			get;
			set;
		}

		[XmlElement("name")]
		public string Name
		{
			get;
			set;
		}
	}
}
