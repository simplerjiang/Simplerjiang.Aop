using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ProdMarkRelationVO : AopObject
	{
		[XmlElement("mark_code")]
		public string MarkCode
		{
			get;
			set;
		}

		[XmlElement("mark_type")]
		public string MarkType
		{
			get;
			set;
		}

		[XmlElement("prod_code")]
		public string ProdCode
		{
			get;
			set;
		}

		[XmlElement("prod_version")]
		public string ProdVersion
		{
			get;
			set;
		}
	}
}
