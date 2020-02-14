using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayEcoMycarPromoTicketPushResponse : AopResponse
	{
		[XmlElement("sp_apply_no")]
		public string SpApplyNo
		{
			get;
			set;
		}
	}
}
