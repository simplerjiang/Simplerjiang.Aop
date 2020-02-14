using Aop.Api.Domain;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayInsSceneCouponSendResponse : AopResponse
	{
		[XmlElement("certificate")]
		public InsCertificate Certificate
		{
			get;
			set;
		}

		[XmlElement("compaign_id")]
		public string CompaignId
		{
			get;
			set;
		}

		[XmlElement("flow_id")]
		public string FlowId
		{
			get;
			set;
		}

		[XmlElement("product")]
		public InsProduct Product
		{
			get;
			set;
		}
	}
}
