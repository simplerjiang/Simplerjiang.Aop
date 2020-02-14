using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayEbppProdmodeProvcityQueryModel : AopObject
	{
		[XmlElement("adcode")]
		public string Adcode
		{
			get;
			set;
		}

		[XmlElement("query_type")]
		public string QueryType
		{
			get;
			set;
		}
	}
}
