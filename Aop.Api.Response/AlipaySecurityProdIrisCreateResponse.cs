using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipaySecurityProdIrisCreateResponse : AopResponse
	{
		[XmlElement("biz_token")]
		public string BizToken
		{
			get;
			set;
		}

		[XmlElement("ext_info")]
		public string ExtInfo
		{
			get;
			set;
		}

		[XmlElement("iris_id")]
		public string IrisId
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
