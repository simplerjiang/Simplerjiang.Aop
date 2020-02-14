using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class RoyaltyDetailInfos : AopObject
	{
		[XmlElement("amount")]
		public long Amount
		{
			get;
			set;
		}

		[XmlElement("amount_percentage")]
		public string AmountPercentage
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

		[XmlElement("desc")]
		public string Desc
		{
			get;
			set;
		}

		[XmlElement("out_relation_id")]
		public string OutRelationId
		{
			get;
			set;
		}

		[XmlElement("serial_no")]
		public long SerialNo
		{
			get;
			set;
		}

		[XmlElement("trans_in")]
		public string TransIn
		{
			get;
			set;
		}

		[XmlElement("trans_in_type")]
		public string TransInType
		{
			get;
			set;
		}

		[XmlElement("trans_out")]
		public string TransOut
		{
			get;
			set;
		}

		[XmlElement("trans_out_type")]
		public string TransOutType
		{
			get;
			set;
		}
	}
}
