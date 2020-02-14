using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class AlipayFundTransBatchCreateorderModel : AopObject
	{
		[XmlElement("batch_no")]
		public string BatchNo
		{
			get;
			set;
		}

		[XmlElement("ext_param")]
		public string ExtParam
		{
			get;
			set;
		}

		[XmlElement("pay_amount")]
		public string PayAmount
		{
			get;
			set;
		}

		[XmlElement("payee_id")]
		public string PayeeId
		{
			get;
			set;
		}

		[XmlElement("payer_id")]
		public string PayerId
		{
			get;
			set;
		}

		[XmlElement("token")]
		public string Token
		{
			get;
			set;
		}
	}
}
