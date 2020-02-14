using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class MybankCreditSupplychainInventoryOutApplyResponse : AopResponse
	{
		[XmlElement("normal_int_amt")]
		public string NormalIntAmt
		{
			get;
			set;
		}

		[XmlElement("ovd_int_amt")]
		public string OvdIntAmt
		{
			get;
			set;
		}

		[XmlElement("ovd_int_pen_int_amt")]
		public string OvdIntPenIntAmt
		{
			get;
			set;
		}

		[XmlElement("ovd_prin_pen_int_amt")]
		public string OvdPrinPenIntAmt
		{
			get;
			set;
		}

		[XmlElement("prin_amt")]
		public string PrinAmt
		{
			get;
			set;
		}

		[XmlElement("repay_amt")]
		public string RepayAmt
		{
			get;
			set;
		}
	}
}
