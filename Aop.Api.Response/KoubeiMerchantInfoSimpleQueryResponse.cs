using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiMerchantInfoSimpleQueryResponse : AopResponse
	{
		[XmlElement("operator_prefix")]
		public string OperatorPrefix
		{
			get;
			set;
		}

		[XmlElement("partner_id")]
		public string PartnerId
		{
			get;
			set;
		}

		[XmlElement("user_name")]
		public string UserName
		{
			get;
			set;
		}
	}
}
