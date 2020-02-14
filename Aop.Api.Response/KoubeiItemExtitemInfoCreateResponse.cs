using System.Xml.Serialization;

namespace Aop.Api.Response
{
	public class KoubeiItemExtitemInfoCreateResponse : AopResponse
	{
		[XmlElement("id")]
		public string Id
		{
			get;
			set;
		}
	}
}
