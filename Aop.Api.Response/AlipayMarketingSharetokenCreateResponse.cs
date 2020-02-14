using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingSharetokenCreateResponse : AopResponse
	{
		[XmlElement("expire_date")]
		public string ExpireDate
		{
			get;
			set;
		}

		[XmlElement("guider_str_1")]
		public string GuiderStr1
		{
			get;
			set;
		}

		[XmlElement("guider_str_2")]
		public string GuiderStr2
		{
			get;
			set;
		}

		[XmlElement("share_token")]
		public string ShareToken
		{
			get;
			set;
		}

		[XmlArray("start_date")]
		[XmlArrayItem("date")]
		public List<string> StartDate
		{
			get;
			set;
		}
	}
}
