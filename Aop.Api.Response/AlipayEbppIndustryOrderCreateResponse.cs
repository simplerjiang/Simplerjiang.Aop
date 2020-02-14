using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppIndustryOrderCreateResponse : AopResponse
	{
		[XmlElement("extend_field")]
		public string ExtendField
		{
			get;
			set;
		}

		[XmlElement("order_no")]
		public string OrderNo
		{
			get;
			set;
		}

		[XmlElement("out_order_no")]
		public string OutOrderNo
		{
			get;
			set;
		}
	}
}
