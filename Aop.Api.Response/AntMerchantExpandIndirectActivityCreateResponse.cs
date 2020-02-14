using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AntMerchantExpandIndirectActivityCreateResponse : AopResponse
	{
		[XmlElement("has_apply")]
		public string HasApply
		{
			get;
			set;
		}

		[XmlElement("order_id")]
		public string OrderId
		{
			get;
			set;
		}
	}
}
