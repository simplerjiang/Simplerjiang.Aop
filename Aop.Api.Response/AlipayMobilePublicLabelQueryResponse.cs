using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMobilePublicLabelQueryResponse : AopResponse
	{
		[XmlElement("code")]
		public new string Code
		{
			get;
			set;
		}

		[XmlArray("labels")]
		[XmlArrayItem("string")]
		public List<string> Labels
		{
			get;
			set;
		}

		[XmlElement("msg")]
		public new string Msg
		{
			get;
			set;
		}
	}
}
