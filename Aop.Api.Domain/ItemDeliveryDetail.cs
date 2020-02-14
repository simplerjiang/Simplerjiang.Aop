using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ItemDeliveryDetail : AopObject
	{
		[XmlElement("amount")]
		public string Amount
		{
			get;
			set;
		}

		[XmlElement("assign_item_id")]
		public string AssignItemId
		{
			get;
			set;
		}

		[XmlElement("batch_no")]
		public string BatchNo
		{
			get;
			set;
		}

		[XmlElement("logistic_code")]
		public string LogisticCode
		{
			get;
			set;
		}

		[XmlElement("logistics_name")]
		public string LogisticsName
		{
			get;
			set;
		}

		[XmlElement("logistics_no")]
		public string LogisticsNo
		{
			get;
			set;
		}
	}
}
