using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ProdLORelationVO : AopObject
	{
		[XmlElement("lo_code")]
		public string LoCode
		{
			get;
			set;
		}

		[XmlElement("lo_type")]
		public string LoType
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
