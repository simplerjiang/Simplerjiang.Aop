using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEbppCommonBillQueryResponse : AopResponse
	{
		[XmlElement("bill_key")]
		public string BillKey
		{
			get;
			set;
		}

		[XmlElement("bill_no")]
		public string BillNo
		{
			get;
			set;
		}

		[XmlElement("charge_inst")]
		public string ChargeInst
		{
			get;
			set;
		}

		[XmlElement("chargeoff_inst")]
		public string ChargeoffInst
		{
			get;
			set;
		}

		[XmlElement("gmt_create")]
		public string GmtCreate
		{
			get;
			set;
		}

		[XmlElement("gmt_pay")]
		public string GmtPay
		{
			get;
			set;
		}

		[XmlElement("status")]
		public string Status
		{
			get;
			set;
		}
	}
}
