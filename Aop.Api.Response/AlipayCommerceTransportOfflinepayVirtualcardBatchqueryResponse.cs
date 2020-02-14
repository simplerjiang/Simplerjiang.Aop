using Aop.Api.Domain;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceTransportOfflinepayVirtualcardBatchqueryResponse : AopResponse
	{
		[XmlArray("card_models")]
		[XmlArrayItem("alipay_query_card_model_result")]
		public List<AlipayQueryCardModelResult> CardModels
		{
			get;
			set;
		}

		[XmlElement("error_message")]
		public string ErrorMessage
		{
			get;
			set;
		}

		[XmlElement("sub_error_code")]
		public string SubErrorCode
		{
			get;
			set;
		}
	}
}
