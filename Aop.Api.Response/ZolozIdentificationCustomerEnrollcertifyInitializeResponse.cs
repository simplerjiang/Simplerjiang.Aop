using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class ZolozIdentificationCustomerEnrollcertifyInitializeResponse : AopResponse
	{
		[XmlElement("biz_id")]
		public string BizId
		{
			get;
			set;
		}

		[XmlElement("zim_id")]
		public string ZimId
		{
			get;
			set;
		}
	}
}
