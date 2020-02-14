using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayMarketingPassShopBindResponse : AopResponse
	{
		[XmlElement("binded")]
		public long Binded
		{
			get;
			set;
		}

		[XmlElement("total_binded")]
		public long TotalBinded
		{
			get;
			set;
		}
	}
}
