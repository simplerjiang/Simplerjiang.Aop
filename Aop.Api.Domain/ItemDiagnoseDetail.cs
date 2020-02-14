using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
	[Serializable]
	public class ItemDiagnoseDetail : AopObject
	{
		[XmlElement("hot_grade")]
		public long HotGrade
		{
			get;
			set;
		}

		[XmlElement("hot_value")]
		public long HotValue
		{
			get;
			set;
		}

		[XmlElement("item_diagnose")]
		public string ItemDiagnose
		{
			get;
			set;
		}

		[XmlElement("item_diagnose_desc")]
		public string ItemDiagnoseDesc
		{
			get;
			set;
		}

		[XmlElement("item_id")]
		public string ItemId
		{
			get;
			set;
		}

		[XmlElement("item_name")]
		public string ItemName
		{
			get;
			set;
		}

		[XmlElement("item_price")]
		public long ItemPrice
		{
			get;
			set;
		}

		[XmlElement("rec_ninety_consume_uid_cnt")]
		public long RecNinetyConsumeUidCnt
		{
			get;
			set;
		}

		[XmlElement("rec_ninety_rebuy_uid_cnt")]
		public long RecNinetyRebuyUidCnt
		{
			get;
			set;
		}

		[XmlElement("rec_seven_sale_amt")]
		public long RecSevenSaleAmt
		{
			get;
			set;
		}

		[XmlElement("rec_seven_sale_cnt")]
		public long RecSevenSaleCnt
		{
			get;
			set;
		}

		[XmlElement("rec_sixty_consume_uid_cnt")]
		public long RecSixtyConsumeUidCnt
		{
			get;
			set;
		}

		[XmlElement("rec_sixty_rebuy_uid_cnt")]
		public long RecSixtyRebuyUidCnt
		{
			get;
			set;
		}

		[XmlElement("rec_thirty_consume_uid_cnt")]
		public string RecThirtyConsumeUidCnt
		{
			get;
			set;
		}

		[XmlElement("rec_thirty_rebuy_uid_cnt")]
		public long RecThirtyRebuyUidCnt
		{
			get;
			set;
		}

		[XmlElement("rec_thirty_sale_amt")]
		public long RecThirtySaleAmt
		{
			get;
			set;
		}

		[XmlElement("rec_thirty_sale_cnt")]
		public long RecThirtySaleCnt
		{
			get;
			set;
		}

		[XmlElement("report_date")]
		public string ReportDate
		{
			get;
			set;
		}
	}
}
