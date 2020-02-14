using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayCommerceCityfacilitatorVoucherGenerateResponse : AopResponse
	{
		[XmlElement("expired_date")]
		public string ExpiredDate
		{
			get;
			set;
		}

		[XmlElement("qr_code_no")]
		public string QrCodeNo
		{
			get;
			set;
		}

		[XmlElement("ticket_no")]
		public string TicketNo
		{
			get;
			set;
		}
	}
}
