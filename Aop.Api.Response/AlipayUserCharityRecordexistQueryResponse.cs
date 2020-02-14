using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayUserCharityRecordexistQueryResponse : AopResponse
	{
		[XmlElement("donation_tag")]
		public bool DonationTag
		{
			get;
			set;
		}
	}
}
