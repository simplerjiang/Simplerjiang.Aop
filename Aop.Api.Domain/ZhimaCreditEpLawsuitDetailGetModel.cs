using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaCreditEpLawsuitDetailGetModel : AopObject
	{
		[XmlElement("lawsuit_id")]
		public string LawsuitId
		{
			get;
			set;
		}

		[XmlElement("lawsuit_type")]
		public string LawsuitType
		{
			get;
			set;
		}

		[XmlElement("product_code")]
		public string ProductCode
		{
			get;
			set;
		}

		[XmlElement("transaction_id")]
		public string TransactionId
		{
			get;
			set;
		}
	}
}
