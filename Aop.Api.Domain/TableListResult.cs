using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class TableListResult : AopObject
	{
		[XmlElement("table_name")]
		public string TableName
		{
			get;
			set;
		}

		[XmlElement("table_num")]
		public string TableNum
		{
			get;
			set;
		}
	}
}
