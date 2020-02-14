using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiCraftsmanDataProviderCreateResponse : AopResponse
	{
		[XmlElement("craftsman_id")]
		public string CraftsmanId
		{
			get;
			set;
		}
	}
}
