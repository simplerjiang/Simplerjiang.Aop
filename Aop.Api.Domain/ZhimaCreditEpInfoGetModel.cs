using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ZhimaCreditEpInfoGetModel : AopObject
	{
		[XmlElement("data_type")]
		public string DataType
		{
			get;
			set;
		}

		[XmlElement("data_value")]
		public string DataValue
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
