using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayOpenAppQrcodeCreateModel : AopObject
	{
		[XmlElement("describe")]
		public string Describe
		{
			get;
			set;
		}

		[XmlElement("query_param")]
		public string QueryParam
		{
			get;
			set;
		}

		[XmlElement("url_param")]
		public string UrlParam
		{
			get;
			set;
		}
	}
}
