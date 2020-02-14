using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class AlipayOpenPublicAdvertCreateResponse : AopResponse
	{
		[XmlElement("advert_id")]
		public string AdvertId
		{
			get;
			set;
		}
	}
}
